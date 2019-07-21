namespace Office_Desk
{
    partial class ManageClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.client__groupid = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.office_deskDataSet = new Office_Desk.office_deskDataSet();
            this.Aadhar_link_status = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.client = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.client_email = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.bank_accountType = new System.Windows.Forms.ComboBox();
            this.accounttype = new System.Windows.Forms.Label();
            this.bankaccount = new System.Windows.Forms.Label();
            this.bank_accountNo = new System.Windows.Forms.TextBox();
            this.client_group = new System.Windows.Forms.TextBox();
            this.group = new System.Windows.Forms.Label();
            this.client_GSTIN = new System.Windows.Forms.TextBox();
            this.GSTIN = new System.Windows.Forms.Label();
            this.Aadhaar_link_status = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientAddress = new System.Windows.Forms.TextBox();
            this.ClientPAN = new System.Windows.Forms.TextBox();
            this.ClientAadhar = new System.Windows.Forms.TextBox();
            this.ClientContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new Office_Desk.office_deskDataSetTableAdapters.clientsTableAdapter();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.office_deskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.client__groupid);
            this.groupBox1.Controls.Add(this.Aadhar_link_status);
            this.groupBox1.Controls.Add(this.client);
            this.groupBox1.Controls.Add(this.client_email);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.bank_accountType);
            this.groupBox1.Controls.Add(this.accounttype);
            this.groupBox1.Controls.Add(this.bankaccount);
            this.groupBox1.Controls.Add(this.bank_accountNo);
            this.groupBox1.Controls.Add(this.client_group);
            this.groupBox1.Controls.Add(this.group);
            this.groupBox1.Controls.Add(this.client_GSTIN);
            this.groupBox1.Controls.Add(this.GSTIN);
            this.groupBox1.Controls.Add(this.Aadhaar_link_status);
            this.groupBox1.Controls.Add(this.search_textbox);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ClientAddress);
            this.groupBox1.Controls.Add(this.ClientPAN);
            this.groupBox1.Controls.Add(this.ClientAadhar);
            this.groupBox1.Controls.Add(this.ClientContact);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(99, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Client";
            // 
            // client__groupid
            // 
            this.client__groupid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "group_id", true));
            this.client__groupid.Location = new System.Drawing.Point(745, 97);
            this.client__groupid.Name = "client__groupid";
            this.client__groupid.Size = new System.Drawing.Size(6, 2);
            this.client__groupid.TabIndex = 27;
            this.client__groupid.Values.Text = "";
            this.client__groupid.Visible = false;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.office_deskDataSet;
            // 
            // office_deskDataSet
            // 
            this.office_deskDataSet.DataSetName = "office_deskDataSet";
            this.office_deskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Aadhar_link_status
            // 
            this.Aadhar_link_status.Location = new System.Drawing.Point(587, 172);
            this.Aadhar_link_status.Name = "Aadhar_link_status";
            this.Aadhar_link_status.Size = new System.Drawing.Size(100, 20);
            this.Aadhar_link_status.TabIndex = 26;
            // 
            // client
            // 
            this.client.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "name", true));
            this.client.DataSource = this.clientsBindingSource;
            this.client.DropDownWidth = 430;
            this.client.Location = new System.Drawing.Point(295, 61);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(430, 21);
            this.client.TabIndex = 25;
            this.client.Text = "select client";
            // 
            // client_email
            // 
            this.client_email.Location = new System.Drawing.Point(521, 136);
            this.client_email.Name = "client_email";
            this.client_email.Size = new System.Drawing.Size(204, 20);
            this.client_email.TabIndex = 24;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(483, 143);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 23;
            this.Email.Text = "Email";
            // 
            // bank_accountType
            // 
            this.bank_accountType.FormattingEnabled = true;
            this.bank_accountType.Location = new System.Drawing.Point(521, 249);
            this.bank_accountType.Name = "bank_accountType";
            this.bank_accountType.Size = new System.Drawing.Size(121, 21);
            this.bank_accountType.TabIndex = 22;
            // 
            // accounttype
            // 
            this.accounttype.AutoSize = true;
            this.accounttype.Location = new System.Drawing.Point(466, 252);
            this.accounttype.Name = "accounttype";
            this.accounttype.Size = new System.Drawing.Size(53, 13);
            this.accounttype.TabIndex = 21;
            this.accounttype.Text = "A/C Type";
            // 
            // bankaccount
            // 
            this.bankaccount.AutoSize = true;
            this.bankaccount.Location = new System.Drawing.Point(175, 258);
            this.bankaccount.Name = "bankaccount";
            this.bankaccount.Size = new System.Drawing.Size(74, 13);
            this.bankaccount.TabIndex = 20;
            this.bankaccount.Text = "Bank A/C No.";
            // 
            // bank_accountNo
            // 
            this.bank_accountNo.Location = new System.Drawing.Point(295, 252);
            this.bank_accountNo.Name = "bank_accountNo";
            this.bank_accountNo.Size = new System.Drawing.Size(165, 20);
            this.bank_accountNo.TabIndex = 19;
            // 
            // client_group
            // 
            this.client_group.Location = new System.Drawing.Point(295, 98);
            this.client_group.Name = "client_group";
            this.client_group.Size = new System.Drawing.Size(430, 20);
            this.client_group.TabIndex = 18;
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Location = new System.Drawing.Point(172, 105);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(75, 13);
            this.group.TabIndex = 17;
            this.group.Text = "Client\'s  Group";
            // 
            // client_GSTIN
            // 
            this.client_GSTIN.Location = new System.Drawing.Point(521, 204);
            this.client_GSTIN.Name = "client_GSTIN";
            this.client_GSTIN.Size = new System.Drawing.Size(155, 20);
            this.client_GSTIN.TabIndex = 16;
            // 
            // GSTIN
            // 
            this.GSTIN.AutoSize = true;
            this.GSTIN.Location = new System.Drawing.Point(483, 211);
            this.GSTIN.Name = "GSTIN";
            this.GSTIN.Size = new System.Drawing.Size(40, 13);
            this.GSTIN.TabIndex = 15;
            this.GSTIN.Text = "GSTIN";
            // 
            // Aadhaar_link_status
            // 
            this.Aadhaar_link_status.AutoSize = true;
            this.Aadhaar_link_status.Location = new System.Drawing.Point(483, 177);
            this.Aadhaar_link_status.Name = "Aadhaar_link_status";
            this.Aadhaar_link_status.Size = new System.Drawing.Size(97, 13);
            this.Aadhaar_link_status.TabIndex = 14;
            this.Aadhaar_link_status.Text = "Aadhar Link Status";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(230, 17);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(495, 20);
            this.search_textbox.TabIndex = 13;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(151, 24);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(41, 13);
            this.search.TabIndex = 12;
            this.search.Text = "Search";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(482, 378);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(295, 378);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PAN No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aadhar No.";
            // 
            // ClientAddress
            // 
            this.ClientAddress.Location = new System.Drawing.Point(295, 297);
            this.ClientAddress.Name = "ClientAddress";
            this.ClientAddress.Size = new System.Drawing.Size(430, 20);
            this.ClientAddress.TabIndex = 6;
            // 
            // ClientPAN
            // 
            this.ClientPAN.Location = new System.Drawing.Point(295, 208);
            this.ClientPAN.Name = "ClientPAN";
            this.ClientPAN.Size = new System.Drawing.Size(165, 20);
            this.ClientPAN.TabIndex = 5;
            // 
            // ClientAadhar
            // 
            this.ClientAadhar.Location = new System.Drawing.Point(295, 170);
            this.ClientAadhar.Name = "ClientAadhar";
            this.ClientAadhar.Size = new System.Drawing.Size(167, 20);
            this.ClientAadhar.TabIndex = 4;
            // 
            // ClientContact
            // 
            this.ClientContact.Location = new System.Drawing.Point(295, 137);
            this.ClientContact.Name = "ClientContact";
            this.ClientContact.Size = new System.Drawing.Size(167, 20);
            this.ClientContact.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "clients";
            this.clientsBindingSource1.DataSource = this.office_deskDataSet;
            // 
            // ManageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 555);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageClient";
            this.Text = "ManageClient";
            this.Load += new System.EventHandler(this.ManageClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.office_deskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientPAN;
        private System.Windows.Forms.TextBox ClientAadhar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientAddress;
        private System.Windows.Forms.TextBox client_GSTIN;
        private System.Windows.Forms.Label GSTIN;
        private System.Windows.Forms.Label Aadhaar_link_status;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.ComboBox bank_accountType;
        private System.Windows.Forms.Label accounttype;
        private System.Windows.Forms.Label bankaccount;
        private System.Windows.Forms.TextBox bank_accountNo;
        private System.Windows.Forms.TextBox client_group;
        private System.Windows.Forms.Label group;
        private System.Windows.Forms.TextBox client_email;
        private System.Windows.Forms.Label Email;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox client;
        private Office_Desk.office_deskDataSet office_deskDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Office_Desk.office_deskDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Aadhar_link_status;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel client__groupid;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
    }
}