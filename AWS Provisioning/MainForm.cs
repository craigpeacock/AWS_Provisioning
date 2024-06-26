using Amazon;
using Amazon.IoT;
using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AWS_Provisioning
{
    public partial class MainForm : Form
    {
        AWSLibrary test = new AWSLibrary();

        public MainForm()
        {
            InitializeComponent();
        }
        
        private async void CheckAWSCredentials()
        {
            CredentialProfile basicProfile;
            AWSCredentials awsCredentials;
            var sharedFile = new SharedCredentialsFile();
            if (sharedFile.TryGetProfile(cbAWSProfile.Text, out basicProfile) &&
                AWSCredentialsFactory.TryGetAWSCredentials(basicProfile, sharedFile, out awsCredentials))
            {
                labelAWSRegionField.Text = basicProfile.Region.ToString();
                labelAWSAccountField.Text = "Querying";
                labelAWSARNField.Text = "Querying";

                var ssoCredentials = awsCredentials as SSOAWSCredentials;
                if (ssoCredentials != null)
                {
                    tbOutputLog.AppendText("Profile is SSO. Setting up SSO login\r\n");
                    ssoCredentials.Options.ClientName = "AWS Provisioning App";
                    ssoCredentials.Options.SsoVerificationCallback = args =>
                    {
                        if (MessageBox.Show("Open Web Browser to Authenticate\r\nRequest User Code " + args.UserCode, "Requesting SSO Authentication", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        { // Launch a browser window that prompts the SSO user to complete an SSO login.
                          //  This method is only invoked if the session doesn't already have a valid SSO token.
                          // NOTE: Process.Start might not support launching a browser on macOS or Linux. If not,
                          //       use an appropriate mechanism on those systems instead.
                            Process.Start(new ProcessStartInfo
                            {

                                FileName = args.VerificationUriComplete,
                                UseShellExecute = true
                            });
                        }
                    };
                }
                else
                {
                    tbOutputLog.AppendText("Profile is not SSO\r\n");
                }

                try
                {
                    var client = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient(awsCredentials, basicProfile.Region);
                    var callerIdRequest = new GetCallerIdentityRequest();
                    GetCallerIdentityResponse response = await client.GetCallerIdentityAsync(callerIdRequest);
                    {
                        labelAWSAccountField.Text = response.Account;
                        labelAWSARNField.Text = response.Arn;
                    };
                }
                catch (Exception ex)
                {
                    tbOutputLog.AppendText(ex.Message);
                }
            }
        }
        private void cbAWSProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAWSCredentials();
        }

        private async void bCreateThing_Click(object sender, EventArgs e)
        {
            AmazonIoTClient client = test.AWSClientAuthenication(cbAWSProfile.Text);

            tbOutputLog.AppendText("Connected to: " + client.Config.RegionEndpoint.ToString() + "\r\n");

            var request = new Amazon.IoT.Model.CreateThingRequest();
            var response = new CreateThingResponse();

            request.ThingName = tbThingName.Text;
            request.ThingTypeName = cbThingTypes.Text;

            try
            {
                response = await client.CreateThingAsync(request);
                tbOutputLog.AppendText("Create Thing (" + response.ThingArn + "): " + response.HttpStatusCode.ToString() + "\r\n");
            }
            catch (ResourceAlreadyExistsException ex)
            {
                tbOutputLog.AppendText("Error " + response.ThingName + " already exists");
            }

            // Create Keys and Certificates
            var reqCertificate = new Amazon.IoT.Model.CreateKeysAndCertificateRequest();
            reqCertificate.SetAsActive = true;
            CreateKeysAndCertificateResponse resCertificate = await client.CreateKeysAndCertificateAsync(reqCertificate);
            tbCertificatePem.AppendText(resCertificate.CertificatePem);
            tbPrivateKey.AppendText(resCertificate.KeyPair.PrivateKey);
            tbPublicKey.AppendText(resCertificate.KeyPair.PublicKey);
            tbOutputLog.AppendText("Create Keys and Certificates (" + resCertificate.CertificateId.ToString() + "): " + resCertificate.HttpStatusCode.ToString() + "\r\n");

            // Add Security Policy to Certificate
            var reqPolicy = new Amazon.IoT.Model.AttachPolicyRequest();
            reqPolicy.Target = resCertificate.CertificateArn;
            reqPolicy.PolicyName = cbPolicies.Text;
            AttachPolicyResponse resPolicy = await client.AttachPolicyAsync(reqPolicy);
            tbOutputLog.AppendText("Attach Security Policy to Certificate: " + resPolicy.HttpStatusCode.ToString() + "\r\n");

            // Attach Certificate to a Thing
            var reqAttachThing = new Amazon.IoT.Model.AttachThingPrincipalRequest();
            reqAttachThing.Principal = resCertificate.CertificateArn;
            reqAttachThing.ThingName = tbThingName.Text;
            AttachThingPrincipalResponse resAttachThing = await client.AttachThingPrincipalAsync(reqAttachThing);
            tbOutputLog.AppendText("Attach Certificate to Thing: " + resAttachThing.HttpStatusCode.ToString() + "\r\n");

            client.Dispose();
        }

        private async void bLoadThingTypes_ClickAsync(object sender, EventArgs e)
        {
            AmazonIoTClient client = test.AWSClientAuthenication(cbAWSProfile.Text);

            // Get Thing Types
            var reqListThingTypes = new Amazon.IoT.Model.ListThingTypesRequest();
            reqListThingTypes.MaxResults = 50;
            ListThingTypesResponse resListThingTypes = await client.ListThingTypesAsync(reqListThingTypes);
            tbOutputLog.AppendText("Found " + resListThingTypes.ThingTypes.Count.ToString() + " Thing Types:\r\n");

            // Populate ComboBox
            cbThingTypes.Items.Clear();
            foreach (var item in resListThingTypes.ThingTypes)
            {
                tbOutputLog.AppendText(item.ThingTypeName + "\r\n");
                cbThingTypes.Items.Add(item.ThingTypeName);
            }
            cbThingTypes.SelectedIndex = 0;

            client.Dispose();
        }

        private async void bLoadGroups_Click(object sender, EventArgs e)
        {
            AmazonIoTClient client = test.AWSClientAuthenication(cbAWSProfile.Text);

            // Get Thing Groups
            var reqListThingGroups = new Amazon.IoT.Model.ListThingGroupsRequest();
            reqListThingGroups.MaxResults = 100;

            try
            {
                ListThingGroupsResponse resListThingGroups = await client.ListThingGroupsAsync(reqListThingGroups);

                tbOutputLog.AppendText("Found " + resListThingGroups.ThingGroups.Count.ToString() + " Thing Groups:\r\n");

                // Populate ComboBox
                cbThingGroups.Items.Clear();
                foreach (var item in resListThingGroups.ThingGroups)
                {
                    tbOutputLog.AppendText(item.GroupName + "\r\n");
                    cbThingGroups.Items.Add(item.GroupName);
                }
                cbThingGroups.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                tbOutputLog.AppendText(ex.Message);
            }


            client.Dispose();
        }
        private async void bLoadPolicies_Click(object sender, EventArgs e)
        {
            AmazonIoTClient client = test.AWSClientAuthenication(cbAWSProfile.Text);

            // Get Security Policies
            var reqListPolicies = new Amazon.IoT.Model.ListPoliciesRequest();
            ListPoliciesResponse resListPolicies = await client.ListPoliciesAsync(reqListPolicies);
            tbOutputLog.AppendText("Found " + resListPolicies.Policies.Count.ToString() + " Policies:\r\n");

            // Populate ComboBox
            cbPolicies.Items.Clear();
            foreach (var item in resListPolicies.Policies)
            {
                tbOutputLog.AppendText(item.PolicyName + "\r\n");
                cbPolicies.Items.Add(item.PolicyName);
            }
            cbPolicies.SelectedIndex = 0;

            client.Dispose();
        }

        private void cbAWSProfile_Click(object sender, EventArgs e)
        {
            cbAWSProfile.Items.Clear();

            var chain = new CredentialProfileStoreChain();

            List<CredentialProfile> Profiles = new List<CredentialProfile>();

            Profiles = chain.ListProfiles();

            foreach (CredentialProfile profile in Profiles)
            {
                cbAWSProfile.Items.Add(profile.Name);
                tbOutputLog.AppendText("Profile: " + profile.Name + " Type:" + profile.EndpointUrl + "\r\n");
            }
        }
    }
}