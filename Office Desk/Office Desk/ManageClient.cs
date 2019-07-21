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
    public partial class ManageClient: Form
    {
        public ManageClient()
        {
            InitializeComponent();
        }

        private void ManageClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'office_deskDataSet.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.office_deskDataSet.clients);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            updateClientDetails ucd = new updateClientDetails();
            clients clnt = new clients();
            var gd = new getGroupDetails();
            client__groupid.Visible = true;
            clnt.name = client.Text;
            clnt.pan_no = ClientPAN.Text;
            clnt.aadhar_no = ClientAadhar.Text;
            clnt.aadharLinkStatus = Aadhar_link_status.Text;
            clnt.bank_accountNo = bank_accountNo.Text;
            clnt.accountType = bank_accountType.Text;
            clnt.address = ClientAddress.Text;
            clnt.contact_no = ClientContact.Text;
            clnt.email = client_email.Text;
            clnt.group_id = Convert.ToInt32(client__groupid.Text);
            clnt.gstin = client_GSTIN.Text;

            ucd.updateClient(clnt);
        }
    }
}
