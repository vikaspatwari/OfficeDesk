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

namespace office_desk
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageTasks mt = new ManageTasks();
           
            mt.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Get The current tasks from the database 
            // Create a object to access data and pass on employee id whose tasks are to be fetched.
                getCurrentTasks GCT = new getCurrentTasks();
               IEnumerable<currenttasks> CT = GCT.getTasks(1);
            
            // populate the datagrid view with the  fetched "Task Data"
            foreach (currenttasks t in CT)
            {
               
                dataGridView1.Rows.Add(t.DateOfAssignment,t.ClientID,t.SubjectWithParty,t.areaOfWork,t.priority,t.TaskDescription,
                    t.DocumentsSource,t.assigner,t.status,t.remarks);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
