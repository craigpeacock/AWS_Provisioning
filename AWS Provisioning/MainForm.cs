using Amazon;
using Amazon.IoT;
using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using System.Runtime.CompilerServices;

namespace AWS_Provisioning
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private AmazonIoTClient AWSClientAuthenication()
        {
            //var awsCredentials = new Amazon.Runtime.BasicAWSCredentials(tbAWSAccessKeyID.Text, tbAWSSecretAccessKey.Text);
            //var awsRegion = RegionEndpoint.GetBySystemName("ap-southeast-2");
            //AmazonIoTClient client = new AmazonIoTClient(awsCredentials, awsRegion);

            // Use default credentials 
            var config = new Amazon.IoT.AmazonIoTConfig();
            AmazonIoTClient client = new AmazonIoTClient(config);
            return (client);
        }

        private async void bCreateThing_Click(object sender, EventArgs e)
        {
            AmazonIoTClient client = new MainForm().AWSClientAuthenication();

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
        }

        private async void bLoadThingTypes_ClickAsync(object sender, EventArgs e)
        {
            AmazonIoTClient client = new MainForm().AWSClientAuthenication();

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
        }

        private async void bLoadGroups_Click(object sender, EventArgs e)
        {
            AmazonIoTClient client = new MainForm().AWSClientAuthenication();

            // Get Thing Groups
            var reqListThingGroups = new Amazon.IoT.Model.ListThingGroupsRequest();
            reqListThingGroups.MaxResults = 100;
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
        private async void bLoadPolicies_Click(object sender, EventArgs e)
        {
            AmazonIoTClient client = new MainForm().AWSClientAuthenication();

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
        }
    }
}