using System;
using Office_Desk;
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
    public partial class CurrentTasks : Form
    {
        public CurrentTasks()
        {

            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageTasks mt = new ManageTasks();
           
            mt.Show();
        }

        private void CurrentTasks_Load(object sender, EventArgs e)
        {
            // Get The current tasks from the database 
            // Create a object to access data and pass on employee id whose tasks are to be fetched.
                getCurrentTasks GCT = new getCurrentTasks();
               IEnumerable<currenttasks> CT = GCT.getTasks(GlobalVar.app_userID);
            
            // populate the datagrid view with the  fetched "Task Data"
            foreach (currenttasks t in CT)
            {
                getClientDetails cd = new getClientDetails();
                
                CurrentTasksDataGrid.Rows.Add(t.DateOfAssignment, cd.getClientName(t.ClientID), t.SubjectWithParty,t.areaOfWork,t.priority,t.TaskDescription,
                    t.DocumentsSource,t.assigner,t.status,t.remarks,t.ID,t.ClientID);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CurrentTasksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            int selectedRowIndex = CurrentTasksDataGrid.CurrentCell.RowIndex;
            if (selectedRowIndex >= 0)
            {
                GlobalVar.globalstring = "EditCurrentTask";
                currenttasks ct = new currenttasks();
                string client_name = CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[1].Value.ToString();
                ct.assignee = GlobalVar.app_user;
                ct.DateOfAssignment = Convert.ToDateTime(CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[0].Value.ToString());
                ct.SubjectWithParty = CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[2].Value.ToString();
                ct.areaOfWork = CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[3].Value.ToString();
                ct.priority = CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[4].Value.ToString();
                ct.TaskDescription = CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[5].Value.ToString();
                ct.DocumentsSource = CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[6].Value.ToString();
                ct.assigner = CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[7].Value.ToString();
                ct.status = CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[8].Value.ToString();
                ct.remarks = CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[9].Value.ToString();
                ct.ID = Convert.ToInt32(CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[10].Value);
                ct.ClientID = Convert.ToInt32(CurrentTasksDataGrid.Rows[selectedRowIndex].Cells[11].Value);
                


                ManageTasks mt = new ManageTasks(ct, client_name);
                mt.Show();
            }

        }

        private void File_Click(object sender, EventArgs e)
        {

        }

        private void createTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVar.globalstring = "CreateTask";
            ManageTasks mt = new ManageTasks();

            mt.Show();
        }
    }
}
