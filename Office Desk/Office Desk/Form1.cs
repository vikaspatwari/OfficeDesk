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


namespace Office_Desk
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        protected void newToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = user_name.Text.ToString();
            string password = user_pasword.Text.ToString();
            authenticateUser au = new authenticateUser();
            if (au.check_user(name, password))
            {
                GlobalVar.app_user = name;
                tableLayoutPanel1.Hide();
                CurrentTasks ct = new CurrentTasks();
                ct.Show();
                
            
            }
            else
            {
                MessageBox.Show("username or password is invalid. Access Denied");
            }
       

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClient mc = new ManageClient();
            mc.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTasks mt = new ManageTasks();
            mt.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

   
}
