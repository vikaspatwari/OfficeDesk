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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Get The current tasks from the database 
            // Create a object to access data and pass on employee id whose tasks are to be fetched.
                getCurrentTasks GCT = new getCurrentTasks();
               IEnumerable<current_tasks> CT = GCT.getTasks(1);
            MessageBox.Show("iam herer 1");
            // populate the datagrid view with the  fetched "Task Data"
            foreach (current_tasks t in CT)
            {
                MessageBox.Show("iam herer");
                dataGridView1.Rows.Add(t.DateOfAssignment,t.ClientID,t.SubjectWithParty,t.areaOfWork,t.priority,t.TaskDescription,
                    t.DocumentsSource,t.assigner,t.status,t.remarks);
            }

        }
    }
}
