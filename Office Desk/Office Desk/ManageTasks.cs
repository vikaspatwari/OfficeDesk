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
        }
        public ManageTasks(int taskid)
        {
            
            InitializeComponent();
            task_id = taskid;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            updateCurrentTasks UCT = new updateCurrentTasks();
            currenttasks ct = new currenttasks();
            ct.ID = task_id;
            ct.DateOfAssignment = Convert.ToDateTime(assignment_date.Text);
            ct.assignee = task_assignee.Text;
            ct.priority = task_priority.Text;
            ct.TaskDescription = task_description.Text;
            ct.DocumentsSource = document_source.Text;
            ct.assigner = task_assigner.Text;
            ct.status = task_status.Text;
            ct.remarks = task_remarks.Text;
            UCT.updateTasks(ct);

        }

        private void ManageTasks_Load(object sender, EventArgs e)
        {

        }
    }
}
