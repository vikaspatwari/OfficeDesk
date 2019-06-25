namespace office_desk
{
    partial class ReturnFillling
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
            this.return_remarks = new System.Windows.Forms.TextBox();
            this.Remarks = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.evc_verication_status = new System.Windows.Forms.TextBox();
            this.dispatch_date = new System.Windows.Forms.DateTimePicker();
            this.returnFilling_date = new System.Windows.Forms.DateTimePicker();
            this.returnFilling_ackNo = new System.Windows.Forms.TextBox();
            this.assessment_year = new System.Windows.Forms.TextBox();
            this.client_name = new System.Windows.Forms.ComboBox();
            this.Evcverification = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.return_remarks);
            this.groupBox1.Controls.Add(this.Remarks);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.evc_verication_status);
            this.groupBox1.Controls.Add(this.dispatch_date);
            this.groupBox1.Controls.Add(this.returnFilling_date);
            this.groupBox1.Controls.Add(this.returnFilling_ackNo);
            this.groupBox1.Controls.Add(this.assessment_year);
            this.groupBox1.Controls.Add(this.client_name);
            this.groupBox1.Controls.Add(this.Evcverification);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(89, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Filling";
            // 
            // return_remarks
            // 
            this.return_remarks.Location = new System.Drawing.Point(345, 278);
            this.return_remarks.Name = "return_remarks";
            this.return_remarks.Size = new System.Drawing.Size(359, 20);
            this.return_remarks.TabIndex = 19;
            this.return_remarks.TextChanged += new System.EventHandler(this.return_remarks_TextChanged);
            // 
            // Remarks
            // 
            this.Remarks.AutoSize = true;
            this.Remarks.Location = new System.Drawing.Point(211, 278);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(49, 13);
            this.Remarks.TabIndex = 18;
            this.Remarks.Text = "Remarks";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // evc_verication_status
            // 
            this.evc_verication_status.Location = new System.Drawing.Point(345, 245);
            this.evc_verication_status.Name = "evc_verication_status";
            this.evc_verication_status.Size = new System.Drawing.Size(41, 20);
            this.evc_verication_status.TabIndex = 14;
            // 
            // dispatch_date
            // 
            this.dispatch_date.Location = new System.Drawing.Point(345, 162);
            this.dispatch_date.Name = "dispatch_date";
            this.dispatch_date.Size = new System.Drawing.Size(200, 20);
            this.dispatch_date.TabIndex = 12;
            this.dispatch_date.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // returnFilling_date
            // 
            this.returnFilling_date.Location = new System.Drawing.Point(345, 122);
            this.returnFilling_date.Name = "returnFilling_date";
            this.returnFilling_date.Size = new System.Drawing.Size(200, 20);
            this.returnFilling_date.TabIndex = 11;
            this.returnFilling_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // returnFilling_ackNo
            // 
            this.returnFilling_ackNo.Location = new System.Drawing.Point(345, 201);
            this.returnFilling_ackNo.Name = "returnFilling_ackNo";
            this.returnFilling_ackNo.Size = new System.Drawing.Size(135, 20);
            this.returnFilling_ackNo.TabIndex = 10;
            // 
            // assessment_year
            // 
            this.assessment_year.Location = new System.Drawing.Point(345, 85);
            this.assessment_year.Name = "assessment_year";
            this.assessment_year.Size = new System.Drawing.Size(100, 20);
            this.assessment_year.TabIndex = 9;
            // 
            // client_name
            // 
            this.client_name.FormattingEnabled = true;
            this.client_name.Location = new System.Drawing.Point(345, 44);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(260, 21);
            this.client_name.TabIndex = 8;
            // 
            // Evcverification
            // 
            this.Evcverification.AutoSize = true;
            this.Evcverification.Location = new System.Drawing.Point(208, 248);
            this.Evcverification.Name = "Evcverification";
            this.Evcverification.Size = new System.Drawing.Size(116, 13);
            this.Evcverification.TabIndex = 6;
            this.Evcverification.Text = "EVC Verification Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Acknowledgement No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dispatch Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filling Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assessment Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client ";
            // 
            // ReturnFillling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReturnFillling";
            this.Text = "ReturnFillling";
            this.Load += new System.EventHandler(this.ReturnFillling_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Evcverification;
        private System.Windows.Forms.DateTimePicker dispatch_date;
        private System.Windows.Forms.DateTimePicker returnFilling_date;
        private System.Windows.Forms.TextBox returnFilling_ackNo;
        private System.Windows.Forms.TextBox assessment_year;
        private System.Windows.Forms.ComboBox client_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox evc_verication_status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox return_remarks;
        private System.Windows.Forms.Label Remarks;
    }
}