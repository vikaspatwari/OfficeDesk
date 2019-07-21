using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Office_Desk.AppCode;
using Office_Desk.Models;

namespace Office_Desk
{
    public partial class ManageTasks : Form
    {
        public int task_id;
        public ManageTasks()
        {
            InitializeComponent();
            clientname_textbox.Hide();
            taskAssignee_textbox.Hide();
        }
        public ManageTasks(currenttasks CT,string client)
        {
            
            InitializeComponent();
            if (CT != null)
            {
                client_name.Hide();
                task_assignee.Hide();
                taskAssignee_textbox.Text = CT.assignee;
                assignment_date.Text =CT.DateOfAssignment.ToString();
                clientname_textbox.Text = client;
                task_priority.Text = CT.priority;
                subject_with_party.Text = CT.SubjectWithParty;
                area_of_work.Text = CT.areaOfWork;
                task_description.Text = CT.TaskDescription;
                document_source.Text = CT.DocumentsSource;
                task_assigner.Text = CT.assigner;
                task_status.Text = CT.status;
                task_remarks.Text = CT.remarks;
                
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            updateCurrentTasks UCT = new updateCurrentTasks();
            currenttasks ct = new currenttasks();
            assignee_id.Visible = true;
            client_id.Visible = true;
            ct.ID = task_id;
            ct.empId = Convert.ToInt32(assignee_id.Text);
            ct.ClientID = Convert.ToInt32(client_id.Text);
            ct.DateOfAssignment = Convert.ToDateTime(assignment_date.Text);
            ct.assignee = task_assignee.Text;
            ct.priority = task_priority.Text;
            ct.areaOfWork = area_of_work.Text;
            ct.SubjectWithParty = subject_with_party.Text;
            ct.TaskDescription = task_description.Text;
            ct.DocumentsSource = document_source.Text;
            ct.assigner = task_assigner.Text;
            ct.status = task_status.Text;
            ct.remarks = task_remarks.Text;
            UCT.updateTasks(ct);
            assignee_id.Visible = false;
            client_id.Visible = false;

        }

        private void ManageTasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'office_deskDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.office_deskDataSet.users);
            // TODO: This line of code loads data into the 'office_deskDataSet.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.office_deskDataSet.clients);

            if (GlobalVar.globalstring == "CreateTask")
            {
                task_assigner.Text = GlobalVar.app_user;
            }
            


        }
    }
}
