namespace Office_Desk
{
    partial class ManageTasks
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
            this.client_id = new System.Windows.Forms.Label();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.office_deskDataSet = new Office_Desk.office_deskDataSet();
            this.assignee_id = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task_assignee = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.assignment_date = new System.Windows.Forms.DateTimePicker();
            this.task_assigner = new System.Windows.Forms.ComboBox();
            this.task_remarks = new System.Windows.Forms.TextBox();
            this.task_status = new System.Windows.Forms.TextBox();
            this.document_source = new System.Windows.Forms.TextBox();
            this.task_description = new System.Windows.Forms.TextBox();
            this.area_of_work = new System.Windows.Forms.TextBox();
            this.subject_with_party = new System.Windows.Forms.TextBox();
            this.task_priority = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new Office_Desk.office_deskDataSetTableAdapters.clientsTableAdapter();
            this.usersTableAdapter = new Office_Desk.office_deskDataSetTableAdapters.usersTableAdapter();
            this.client_name = new System.Windows.Forms.ComboBox();
            this.clientname_textbox = new System.Windows.Forms.TextBox();
            this.taskAssignee_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.office_deskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_assignee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taskAssignee_textbox);
            this.groupBox1.Controls.Add(this.clientname_textbox);
            this.groupBox1.Controls.Add(this.client_name);
            this.groupBox1.Controls.Add(this.client_id);
            this.groupBox1.Controls.Add(this.assignee_id);
            this.groupBox1.Controls.Add(this.task_assignee);
            this.groupBox1.Controls.Add(this.assignment_date);
            this.groupBox1.Controls.Add(this.task_assigner);
            this.groupBox1.Controls.Add(this.task_remarks);
            this.groupBox1.Controls.Add(this.task_status);
            this.groupBox1.Controls.Add(this.document_source);
            this.groupBox1.Controls.Add(this.task_description);
            this.groupBox1.Controls.Add(this.area_of_work);
            this.groupBox1.Controls.Add(this.subject_with_party);
            this.groupBox1.Controls.Add(this.task_priority);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(99, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Tasks";
            // 
            // client_id
            // 
            this.client_id.AutoSize = true;
            this.client_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ID", true));
            this.client_id.Location = new System.Drawing.Point(644, 128);
            this.client_id.Name = "client_id";
            this.client_id.Size = new System.Drawing.Size(0, 13);
            this.client_id.TabIndex = 28;
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
            // assignee_id
            // 
            this.assignee_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "ID", true));
            this.assignee_id.Location = new System.Drawing.Point(585, 69);
            this.assignee_id.Name = "assignee_id";
            this.assignee_id.Size = new System.Drawing.Size(6, 2);
            this.assignee_id.TabIndex = 27;
            this.assignee_id.Values.Text = "";
            this.assignee_id.Visible = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.office_deskDataSet;
            // 
            // task_assignee
            // 
            this.task_assignee.DataSource = this.usersBindingSource;
            this.task_assignee.DisplayMember = "user_name";
            this.task_assignee.DropDownWidth = 200;
            this.task_assignee.Location = new System.Drawing.Point(365, 69);
            this.task_assignee.Name = "task_assignee";
            this.task_assignee.Size = new System.Drawing.Size(200, 21);
            this.task_assignee.TabIndex = 26;
            // 
            // assignment_date
            // 
            this.assignment_date.Location = new System.Drawing.Point(365, 96);
            this.assignment_date.Name = "assignment_date";
            this.assignment_date.Size = new System.Drawing.Size(200, 20);
            this.assignment_date.TabIndex = 22;
            // 
            // task_assigner
            // 
            this.task_assigner.FormattingEnabled = true;
            this.task_assigner.Location = new System.Drawing.Point(365, 314);
            this.task_assigner.Name = "task_assigner";
            this.task_assigner.Size = new System.Drawing.Size(217, 21);
            this.task_assigner.TabIndex = 19;
            // 
            // task_remarks
            // 
            this.task_remarks.Location = new System.Drawing.Point(365, 382);
            this.task_remarks.Name = "task_remarks";
            this.task_remarks.Size = new System.Drawing.Size(403, 20);
            this.task_remarks.TabIndex = 18;
            // 
            // task_status
            // 
            this.task_status.Location = new System.Drawing.Point(365, 350);
            this.task_status.Name = "task_status";
            this.task_status.Size = new System.Drawing.Size(152, 20);
            this.task_status.TabIndex = 17;
            // 
            // document_source
            // 
            this.document_source.Location = new System.Drawing.Point(365, 285);
            this.document_source.Name = "document_source";
            this.document_source.Size = new System.Drawing.Size(272, 20);
            this.document_source.TabIndex = 16;
            // 
            // task_description
            // 
            this.task_description.Location = new System.Drawing.Point(365, 253);
            this.task_description.Name = "task_description";
            this.task_description.Size = new System.Drawing.Size(272, 20);
            this.task_description.TabIndex = 15;
            // 
            // area_of_work
            // 
            this.area_of_work.Location = new System.Drawing.Point(365, 223);
            this.area_of_work.Name = "area_of_work";
            this.area_of_work.Size = new System.Drawing.Size(272, 20);
            this.area_of_work.TabIndex = 14;
            // 
            // subject_with_party
            // 
            this.subject_with_party.Location = new System.Drawing.Point(365, 190);
            this.subject_with_party.Name = "subject_with_party";
            this.subject_with_party.Size = new System.Drawing.Size(272, 20);
            this.subject_with_party.TabIndex = 13;
            // 
            // task_priority
            // 
            this.task_priority.Location = new System.Drawing.Point(365, 154);
            this.task_priority.Name = "task_priority";
            this.task_priority.Size = new System.Drawing.Size(27, 20);
            this.task_priority.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Remarks";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Assigner";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Documents Source";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Task Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Priority";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area Of Work";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject With Party";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DateOfAssignment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assignee";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(299, 554);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(464, 553);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // client_name
            // 
            this.client_name.DataSource = this.clientsBindingSource;
            this.client_name.DisplayMember = "name";
            this.client_name.FormattingEnabled = true;
            this.client_name.Location = new System.Drawing.Point(365, 128);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(200, 21);
            this.client_name.TabIndex = 29;
            // 
            // clientname_textbox
            // 
            this.clientname_textbox.Location = new System.Drawing.Point(365, 122);
            this.clientname_textbox.Name = "clientname_textbox";
            this.clientname_textbox.Size = new System.Drawing.Size(200, 20);
            this.clientname_textbox.TabIndex = 30;
            // 
            // taskAssignee_textbox
            // 
            this.taskAssignee_textbox.Location = new System.Drawing.Point(365, 60);
            this.taskAssignee_textbox.Name = "taskAssignee_textbox";
            this.taskAssignee_textbox.Size = new System.Drawing.Size(200, 20);
            this.taskAssignee_textbox.TabIndex = 31;
            // 
            // ManageTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 605);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageTasks";
            this.Text = "ManageTasks";
            this.Load += new System.EventHandler(this.ManageTasks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.office_deskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_assignee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox task_assigner;
        private System.Windows.Forms.TextBox task_remarks;
        private System.Windows.Forms.TextBox task_status;
        private System.Windows.Forms.TextBox document_source;
        private System.Windows.Forms.TextBox task_description;
        private System.Windows.Forms.TextBox area_of_work;
        private System.Windows.Forms.TextBox subject_with_party;
        private System.Windows.Forms.TextBox task_priority;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker assignment_date;
        private office_deskDataSet office_deskDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private office_deskDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private office_deskDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox task_assignee;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel assignee_id;
        private System.Windows.Forms.Label client_id;
        private System.Windows.Forms.ComboBox client_name;
        private System.Windows.Forms.TextBox clientname_textbox;
        private System.Windows.Forms.TextBox taskAssignee_textbox;
    }
}