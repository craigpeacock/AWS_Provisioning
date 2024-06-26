namespace AWS_Provisioning
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bCreateThing = new Button();
            gbCredentials = new GroupBox();
            labelAWSARNField = new Label();
            labelAWSARN = new Label();
            labelAWSAccount = new Label();
            labelAWSAccountField = new Label();
            labelAWSRegionField = new Label();
            labelAWSRegion = new Label();
            labelAWSProfile = new Label();
            cbAWSProfile = new ComboBox();
            tbOutputLog = new TextBox();
            gbLog = new GroupBox();
            gbThing = new GroupBox();
            bLoadPolicies = new Button();
            labelSecurityPolicy = new Label();
            cbPolicies = new ComboBox();
            bLoadGroups = new Button();
            cbThingGroups = new ComboBox();
            bLoadThingTypes = new Button();
            cbThingTypes = new ComboBox();
            labelThingType = new Label();
            labelThingGroup = new Label();
            tbThingName = new TextBox();
            labelThingName = new Label();
            gbCertificates = new GroupBox();
            tbPrivateKey = new TextBox();
            labelPrivateKey = new Label();
            tbPublicKey = new TextBox();
            labelPublicKey = new Label();
            labelCertificatePEM = new Label();
            tbCertificatePem = new TextBox();
            gbCredentials.SuspendLayout();
            gbLog.SuspendLayout();
            gbThing.SuspendLayout();
            gbCertificates.SuspendLayout();
            SuspendLayout();
            // 
            // bCreateThing
            // 
            bCreateThing.Location = new Point(330, 161);
            bCreateThing.Name = "bCreateThing";
            bCreateThing.Size = new Size(104, 23);
            bCreateThing.TabIndex = 0;
            bCreateThing.Text = "Create Thing";
            bCreateThing.UseVisualStyleBackColor = true;
            bCreateThing.Click += bCreateThing_Click;
            // 
            // gbCredentials
            // 
            gbCredentials.Controls.Add(labelAWSARNField);
            gbCredentials.Controls.Add(labelAWSARN);
            gbCredentials.Controls.Add(labelAWSAccount);
            gbCredentials.Controls.Add(labelAWSAccountField);
            gbCredentials.Controls.Add(labelAWSRegionField);
            gbCredentials.Controls.Add(labelAWSRegion);
            gbCredentials.Controls.Add(labelAWSProfile);
            gbCredentials.Controls.Add(cbAWSProfile);
            gbCredentials.Location = new Point(12, 12);
            gbCredentials.Name = "gbCredentials";
            gbCredentials.Size = new Size(503, 135);
            gbCredentials.TabIndex = 2;
            gbCredentials.TabStop = false;
            gbCredentials.Text = "Credentials";
            // 
            // labelAWSARNField
            // 
            labelAWSARNField.Location = new Point(92, 104);
            labelAWSARNField.Name = "labelAWSARNField";
            labelAWSARNField.Size = new Size(399, 15);
            labelAWSARNField.TabIndex = 12;
            labelAWSARNField.Text = "AWS ARN";
            // 
            // labelAWSARN
            // 
            labelAWSARN.AutoSize = true;
            labelAWSARN.Location = new Point(18, 104);
            labelAWSARN.Name = "labelAWSARN";
            labelAWSARN.Size = new Size(31, 15);
            labelAWSARN.TabIndex = 11;
            labelAWSARN.Text = "ARN";
            // 
            // labelAWSAccount
            // 
            labelAWSAccount.AutoSize = true;
            labelAWSAccount.Location = new Point(18, 80);
            labelAWSAccount.Name = "labelAWSAccount";
            labelAWSAccount.Size = new Size(52, 15);
            labelAWSAccount.TabIndex = 10;
            labelAWSAccount.Text = "Account";
            // 
            // labelAWSAccountField
            // 
            labelAWSAccountField.Location = new Point(92, 80);
            labelAWSAccountField.Name = "labelAWSAccountField";
            labelAWSAccountField.Size = new Size(399, 15);
            labelAWSAccountField.TabIndex = 9;
            labelAWSAccountField.Text = "AWS Account";
            // 
            // labelAWSRegionField
            // 
            labelAWSRegionField.Location = new Point(92, 57);
            labelAWSRegionField.Name = "labelAWSRegionField";
            labelAWSRegionField.Size = new Size(399, 15);
            labelAWSRegionField.TabIndex = 7;
            labelAWSRegionField.Text = "AWS Region";
            // 
            // labelAWSRegion
            // 
            labelAWSRegion.AutoSize = true;
            labelAWSRegion.Location = new Point(18, 57);
            labelAWSRegion.Name = "labelAWSRegion";
            labelAWSRegion.Size = new Size(44, 15);
            labelAWSRegion.TabIndex = 6;
            labelAWSRegion.Text = "Region";
            // 
            // labelAWSProfile
            // 
            labelAWSProfile.AutoSize = true;
            labelAWSProfile.Location = new Point(18, 27);
            labelAWSProfile.Name = "labelAWSProfile";
            labelAWSProfile.Size = new Size(68, 15);
            labelAWSProfile.TabIndex = 5;
            labelAWSProfile.Text = "AWS Profile";
            // 
            // cbAWSProfile
            // 
            cbAWSProfile.FormattingEnabled = true;
            cbAWSProfile.Location = new Point(92, 22);
            cbAWSProfile.Name = "cbAWSProfile";
            cbAWSProfile.Size = new Size(399, 23);
            cbAWSProfile.TabIndex = 4;
            cbAWSProfile.SelectedIndexChanged += cbAWSProfile_SelectedIndexChanged;
            cbAWSProfile.Click += cbAWSProfile_Click;
            // 
            // tbOutputLog
            // 
            tbOutputLog.Location = new Point(15, 22);
            tbOutputLog.Multiline = true;
            tbOutputLog.Name = "tbOutputLog";
            tbOutputLog.Size = new Size(1051, 179);
            tbOutputLog.TabIndex = 3;
            // 
            // gbLog
            // 
            gbLog.Controls.Add(tbOutputLog);
            gbLog.Location = new Point(12, 447);
            gbLog.Name = "gbLog";
            gbLog.Size = new Size(1084, 218);
            gbLog.TabIndex = 4;
            gbLog.TabStop = false;
            gbLog.Text = "Log";
            // 
            // gbThing
            // 
            gbThing.Controls.Add(bLoadPolicies);
            gbThing.Controls.Add(labelSecurityPolicy);
            gbThing.Controls.Add(cbPolicies);
            gbThing.Controls.Add(bLoadGroups);
            gbThing.Controls.Add(cbThingGroups);
            gbThing.Controls.Add(bLoadThingTypes);
            gbThing.Controls.Add(cbThingTypes);
            gbThing.Controls.Add(labelThingType);
            gbThing.Controls.Add(labelThingGroup);
            gbThing.Controls.Add(tbThingName);
            gbThing.Controls.Add(labelThingName);
            gbThing.Controls.Add(bCreateThing);
            gbThing.Location = new Point(12, 153);
            gbThing.Name = "gbThing";
            gbThing.Size = new Size(503, 193);
            gbThing.TabIndex = 5;
            gbThing.TabStop = false;
            gbThing.Text = "Thing";
            // 
            // bLoadPolicies
            // 
            bLoadPolicies.Location = new Point(399, 119);
            bLoadPolicies.Name = "bLoadPolicies";
            bLoadPolicies.Size = new Size(92, 23);
            bLoadPolicies.TabIndex = 13;
            bLoadPolicies.Text = "Load Policies";
            bLoadPolicies.UseVisualStyleBackColor = true;
            bLoadPolicies.Click += bLoadPolicies_Click;
            // 
            // labelSecurityPolicy
            // 
            labelSecurityPolicy.AutoSize = true;
            labelSecurityPolicy.Location = new Point(16, 123);
            labelSecurityPolicy.Name = "labelSecurityPolicy";
            labelSecurityPolicy.Size = new Size(96, 15);
            labelSecurityPolicy.TabIndex = 12;
            labelSecurityPolicy.Text = "Certificate Policy";
            // 
            // cbPolicies
            // 
            cbPolicies.FormattingEnabled = true;
            cbPolicies.Location = new Point(141, 119);
            cbPolicies.Name = "cbPolicies";
            cbPolicies.Size = new Size(252, 23);
            cbPolicies.TabIndex = 11;
            // 
            // bLoadGroups
            // 
            bLoadGroups.Location = new Point(399, 62);
            bLoadGroups.Name = "bLoadGroups";
            bLoadGroups.Size = new Size(92, 23);
            bLoadGroups.TabIndex = 9;
            bLoadGroups.Text = "Load Groups";
            bLoadGroups.UseVisualStyleBackColor = true;
            bLoadGroups.Click += bLoadGroups_Click;
            // 
            // cbThingGroups
            // 
            cbThingGroups.FormattingEnabled = true;
            cbThingGroups.Location = new Point(141, 62);
            cbThingGroups.Name = "cbThingGroups";
            cbThingGroups.Size = new Size(252, 23);
            cbThingGroups.TabIndex = 8;
            // 
            // bLoadThingTypes
            // 
            bLoadThingTypes.Location = new Point(399, 90);
            bLoadThingTypes.Name = "bLoadThingTypes";
            bLoadThingTypes.Size = new Size(92, 23);
            bLoadThingTypes.TabIndex = 7;
            bLoadThingTypes.Text = "Load Types";
            bLoadThingTypes.UseVisualStyleBackColor = true;
            bLoadThingTypes.Click += bLoadThingTypes_ClickAsync;
            // 
            // cbThingTypes
            // 
            cbThingTypes.FormattingEnabled = true;
            cbThingTypes.Location = new Point(141, 90);
            cbThingTypes.Name = "cbThingTypes";
            cbThingTypes.Size = new Size(252, 23);
            cbThingTypes.TabIndex = 6;
            // 
            // labelThingType
            // 
            labelThingType.AutoSize = true;
            labelThingType.Location = new Point(15, 94);
            labelThingType.Name = "labelThingType";
            labelThingType.Size = new Size(64, 15);
            labelThingType.TabIndex = 5;
            labelThingType.Text = "Thing Type";
            // 
            // labelThingGroup
            // 
            labelThingGroup.AutoSize = true;
            labelThingGroup.Location = new Point(16, 66);
            labelThingGroup.Name = "labelThingGroup";
            labelThingGroup.Size = new Size(73, 15);
            labelThingGroup.TabIndex = 3;
            labelThingGroup.Text = "Thing Group";
            // 
            // tbThingName
            // 
            tbThingName.Location = new Point(141, 33);
            tbThingName.Name = "tbThingName";
            tbThingName.Size = new Size(350, 23);
            tbThingName.TabIndex = 1;
            // 
            // labelThingName
            // 
            labelThingName.AutoSize = true;
            labelThingName.Location = new Point(17, 36);
            labelThingName.Name = "labelThingName";
            labelThingName.Size = new Size(72, 15);
            labelThingName.TabIndex = 0;
            labelThingName.Text = "Thing Name";
            // 
            // gbCertificates
            // 
            gbCertificates.Controls.Add(tbPrivateKey);
            gbCertificates.Controls.Add(labelPrivateKey);
            gbCertificates.Controls.Add(tbPublicKey);
            gbCertificates.Controls.Add(labelPublicKey);
            gbCertificates.Controls.Add(labelCertificatePEM);
            gbCertificates.Controls.Add(tbCertificatePem);
            gbCertificates.Location = new Point(521, 12);
            gbCertificates.Name = "gbCertificates";
            gbCertificates.Size = new Size(575, 429);
            gbCertificates.TabIndex = 6;
            gbCertificates.TabStop = false;
            gbCertificates.Text = "Certificates";
            // 
            // tbPrivateKey
            // 
            tbPrivateKey.Location = new Point(18, 310);
            tbPrivateKey.Multiline = true;
            tbPrivateKey.Name = "tbPrivateKey";
            tbPrivateKey.Size = new Size(542, 101);
            tbPrivateKey.TabIndex = 5;
            // 
            // labelPrivateKey
            // 
            labelPrivateKey.AutoSize = true;
            labelPrivateKey.Location = new Point(18, 292);
            labelPrivateKey.Name = "labelPrivateKey";
            labelPrivateKey.Size = new Size(65, 15);
            labelPrivateKey.TabIndex = 4;
            labelPrivateKey.Text = "Private Key";
            // 
            // tbPublicKey
            // 
            tbPublicKey.Location = new Point(18, 178);
            tbPublicKey.Multiline = true;
            tbPublicKey.Name = "tbPublicKey";
            tbPublicKey.Size = new Size(542, 101);
            tbPublicKey.TabIndex = 3;
            // 
            // labelPublicKey
            // 
            labelPublicKey.AutoSize = true;
            labelPublicKey.Location = new Point(18, 160);
            labelPublicKey.Name = "labelPublicKey";
            labelPublicKey.Size = new Size(62, 15);
            labelPublicKey.TabIndex = 2;
            labelPublicKey.Text = "Public Key";
            // 
            // labelCertificatePEM
            // 
            labelCertificatePEM.AutoSize = true;
            labelCertificatePEM.Location = new Point(18, 26);
            labelCertificatePEM.Name = "labelCertificatePEM";
            labelCertificatePEM.Size = new Size(88, 15);
            labelCertificatePEM.TabIndex = 1;
            labelCertificatePEM.Text = "Certificate.pem";
            // 
            // tbCertificatePem
            // 
            tbCertificatePem.Location = new Point(18, 43);
            tbCertificatePem.Multiline = true;
            tbCertificatePem.Name = "tbCertificatePem";
            tbCertificatePem.Size = new Size(542, 101);
            tbCertificatePem.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 677);
            Controls.Add(gbCertificates);
            Controls.Add(gbThing);
            Controls.Add(gbLog);
            Controls.Add(gbCredentials);
            Name = "MainForm";
            Text = "Example AWS Provisioning App";
            gbCredentials.ResumeLayout(false);
            gbCredentials.PerformLayout();
            gbLog.ResumeLayout(false);
            gbLog.PerformLayout();
            gbThing.ResumeLayout(false);
            gbThing.PerformLayout();
            gbCertificates.ResumeLayout(false);
            gbCertificates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bCreateThing;
        private GroupBox gbCredentials;
        private TextBox tbOutputLog;
        private GroupBox gbLog;
        private GroupBox gbThing;
        private Label labelThingName;
        private TextBox tbThingName;
        private Label labelThingGroup;
        private Label labelThingType;
        private Button bLoadThingTypes;
        private ComboBox cbThingTypes;
        private Button bLoadGroups;
        private ComboBox cbThingGroups;
        private Button bLoadPolicies;
        private Label labelSecurityPolicy;
        private ComboBox cbPolicies;
        private GroupBox gbCertificates;
        private TextBox tbPublicKey;
        private Label labelPublicKey;
        private Label labelCertificatePEM;
        private TextBox tbCertificatePem;
        private TextBox tbPrivateKey;
        private Label labelPrivateKey;
        private Label labelAWSProfile;
        private ComboBox cbAWSProfile;
        private Label labelAWSRegionField;
        private Label labelAWSRegion;
        private Label labelAWSAccount;
        private Label labelAWSAccountField;
        private Label labelAWSARNField;
        private Label labelAWSARN;
    }
}
