namespace office_desk
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.ClientName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.ClientName);
            this.groupBox1.Location = new System.Drawing.Point(99, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Client";
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
            this.label4.Location = new System.Drawing.Point(172, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PAN No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 174);
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
            this.ClientPAN.Location = new System.Drawing.Point(295, 226);
            this.ClientPAN.Name = "ClientPAN";
            this.ClientPAN.Size = new System.Drawing.Size(100, 20);
            this.ClientPAN.TabIndex = 5;
            // 
            // ClientAadhar
            // 
            this.ClientAadhar.Location = new System.Drawing.Point(295, 167);
            this.ClientAadhar.Name = "ClientAadhar";
            this.ClientAadhar.Size = new System.Drawing.Size(100, 20);
            this.ClientAadhar.TabIndex = 4;
            // 
            // ClientContact
            // 
            this.ClientContact.Location = new System.Drawing.Point(295, 109);
            this.ClientContact.Name = "ClientContact";
            this.ClientContact.Size = new System.Drawing.Size(176, 20);
            this.ClientContact.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client";
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(295, 56);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(430, 20);
            this.ClientName.TabIndex = 0;
            // 
            // ManageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 555);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageClient";
            this.Text = "ManageClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientName;
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
    }
}