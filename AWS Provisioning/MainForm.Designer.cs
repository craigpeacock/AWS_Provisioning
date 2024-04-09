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
            gb_credentials = new GroupBox();
            labelAWSSecretAccessKey = new Label();
            tbAWSSecretAccessKey = new TextBox();
            labelAWSAccessKeyID = new Label();
            tbAWSAccessKeyID = new TextBox();
            tbOutputLog = new TextBox();
            gbLog = new GroupBox();
            gbLoadPolicy = new GroupBox();
            bLoadPolicies = new Button();
            lSecurityPolicy = new Label();
            cbPolicies = new ComboBox();
            bLoadGroups = new Button();
            cbThingGroups = new ComboBox();
            bLoadThingTypes = new Button();
            cbThingTypes = new ComboBox();
            lableThingType = new Label();
            lableThingGroup = new Label();
            tbThingName = new TextBox();
            labelThingName = new Label();
            gbCertificates = new GroupBox();
            tbPrivateKey = new TextBox();
            label3 = new Label();
            tbPublicKey = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbCertificatePem = new TextBox();
            gb_credentials.SuspendLayout();
            gbLog.SuspendLayout();
            gbLoadPolicy.SuspendLayout();
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
            // gb_credentials
            // 
            gb_credentials.Controls.Add(labelAWSSecretAccessKey);
            gb_credentials.Controls.Add(tbAWSSecretAccessKey);
            gb_credentials.Controls.Add(labelAWSAccessKeyID);
            gb_credentials.Controls.Add(tbAWSAccessKeyID);
            gb_credentials.Location = new Point(12, 12);
            gb_credentials.Name = "gb_credentials";
            gb_credentials.Size = new Size(503, 106);
            gb_credentials.TabIndex = 2;
            gb_credentials.TabStop = false;
            gb_credentials.Text = "Credentials";
            // 
            // labelAWSSecretAccessKey
            // 
            labelAWSSecretAccessKey.AutoSize = true;
            labelAWSSecretAccessKey.Location = new Point(16, 58);
            labelAWSSecretAccessKey.Name = "labelAWSSecretAccessKey";
            labelAWSSecretAccessKey.Size = new Size(127, 15);
            labelAWSSecretAccessKey.TabIndex = 3;
            labelAWSSecretAccessKey.Text = "AWS Secret Access Key";
            // 
            // tbAWSSecretAccessKey
            // 
            tbAWSSecretAccessKey.Location = new Point(158, 55);
            tbAWSSecretAccessKey.Name = "tbAWSSecretAccessKey";
            tbAWSSecretAccessKey.Size = new Size(314, 23);
            tbAWSSecretAccessKey.TabIndex = 2;
            // 
            // labelAWSAccessKeyID
            // 
            labelAWSAccessKeyID.AutoSize = true;
            labelAWSAccessKeyID.Location = new Point(16, 29);
            labelAWSAccessKeyID.Name = "labelAWSAccessKeyID";
            labelAWSAccessKeyID.Size = new Size(106, 15);
            labelAWSAccessKeyID.TabIndex = 1;
            labelAWSAccessKeyID.Text = "AWS Access Key ID";
            // 
            // tbAWSAccessKeyID
            // 
            tbAWSAccessKeyID.Location = new Point(158, 26);
            tbAWSAccessKeyID.Name = "tbAWSAccessKeyID";
            tbAWSAccessKeyID.Size = new Size(314, 23);
            tbAWSAccessKeyID.TabIndex = 0;
            // 
            // tbOutputLog
            // 
            tbOutputLog.Location = new Point(15, 22);
            tbOutputLog.Multiline = true;
            tbOutputLog.Name = "tbOutputLog";
            tbOutputLog.Size = new Size(1051, 180);
            tbOutputLog.TabIndex = 3;
            // 
            // gbLog
            // 
            gbLog.Controls.Add(tbOutputLog);
            gbLog.Location = new Point(12, 468);
            gbLog.Name = "gbLog";
            gbLog.Size = new Size(1084, 197);
            gbLog.TabIndex = 4;
            gbLog.TabStop = false;
            gbLog.Text = "Log";
            // 
            // gbLoadPolicy
            // 
            gbLoadPolicy.Controls.Add(bLoadPolicies);
            gbLoadPolicy.Controls.Add(lSecurityPolicy);
            gbLoadPolicy.Controls.Add(cbPolicies);
            gbLoadPolicy.Controls.Add(bLoadGroups);
            gbLoadPolicy.Controls.Add(cbThingGroups);
            gbLoadPolicy.Controls.Add(bLoadThingTypes);
            gbLoadPolicy.Controls.Add(cbThingTypes);
            gbLoadPolicy.Controls.Add(lableThingType);
            gbLoadPolicy.Controls.Add(lableThingGroup);
            gbLoadPolicy.Controls.Add(tbThingName);
            gbLoadPolicy.Controls.Add(labelThingName);
            gbLoadPolicy.Controls.Add(bCreateThing);
            gbLoadPolicy.Location = new Point(12, 124);
            gbLoadPolicy.Name = "gbLoadPolicy";
            gbLoadPolicy.Size = new Size(503, 338);
            gbLoadPolicy.TabIndex = 5;
            gbLoadPolicy.TabStop = false;
            gbLoadPolicy.Text = "Thing";
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
            // lSecurityPolicy
            // 
            lSecurityPolicy.AutoSize = true;
            lSecurityPolicy.Location = new Point(16, 123);
            lSecurityPolicy.Name = "lSecurityPolicy";
            lSecurityPolicy.Size = new Size(96, 15);
            lSecurityPolicy.TabIndex = 12;
            lSecurityPolicy.Text = "Certificate Policy";
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
            // lableThingType
            // 
            lableThingType.AutoSize = true;
            lableThingType.Location = new Point(15, 94);
            lableThingType.Name = "lableThingType";
            lableThingType.Size = new Size(64, 15);
            lableThingType.TabIndex = 5;
            lableThingType.Text = "Thing Type";
            // 
            // lableThingGroup
            // 
            lableThingGroup.AutoSize = true;
            lableThingGroup.Location = new Point(16, 66);
            lableThingGroup.Name = "lableThingGroup";
            lableThingGroup.Size = new Size(73, 15);
            lableThingGroup.TabIndex = 3;
            lableThingGroup.Text = "Thing Group";
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
            gbCertificates.Controls.Add(label3);
            gbCertificates.Controls.Add(tbPublicKey);
            gbCertificates.Controls.Add(label2);
            gbCertificates.Controls.Add(label1);
            gbCertificates.Controls.Add(tbCertificatePem);
            gbCertificates.Location = new Point(521, 12);
            gbCertificates.Name = "gbCertificates";
            gbCertificates.Size = new Size(575, 450);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 292);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Private Key";
            // 
            // tbPublicKey
            // 
            tbPublicKey.Location = new Point(18, 178);
            tbPublicKey.Multiline = true;
            tbPublicKey.Name = "tbPublicKey";
            tbPublicKey.Size = new Size(542, 101);
            tbPublicKey.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 160);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Public Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 26);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Certificate.pem";
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
            Controls.Add(gbLoadPolicy);
            Controls.Add(gbLog);
            Controls.Add(gb_credentials);
            Name = "MainForm";
            Text = "Example AWS Provisioning App";
            gb_credentials.ResumeLayout(false);
            gb_credentials.PerformLayout();
            gbLog.ResumeLayout(false);
            gbLog.PerformLayout();
            gbLoadPolicy.ResumeLayout(false);
            gbLoadPolicy.PerformLayout();
            gbCertificates.ResumeLayout(false);
            gbCertificates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bCreateThing;
        private GroupBox gb_credentials;
        private Label labelAWSAccessKeyID;
        private TextBox tbAWSAccessKeyID;
        private Label labelAWSSecretAccessKey;
        private TextBox tbAWSSecretAccessKey;
        private TextBox tbOutputLog;
        private GroupBox gbLog;
        private GroupBox gbLoadPolicy;
        private Label labelThingName;
        private TextBox tbThingName;
        private Label lableThingGroup;
        private Label lableThingType;
        private Button bLoadThingTypes;
        private ComboBox cbThingTypes;
        private Button bLoadGroups;
        private ComboBox cbThingGroups;
        private Button bLoadPolicies;
        private Label lSecurityPolicy;
        private ComboBox cbPolicies;
        private GroupBox gbCertificates;
        private TextBox tbPublicKey;
        private Label label2;
        private Label label1;
        private TextBox tbCertificatePem;
        private TextBox tbPrivateKey;
        private Label label3;
    }
}
