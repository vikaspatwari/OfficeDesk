using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Desk.Models;
namespace Office_Desk.AppCode
{
    public class updateClientDetails
    {
        public void updateClient(clients clnt )
        {
            OfficeDeskDB db = new OfficeDeskDB();
            var client = from clients in db.clientss
                         where clients.ID == clnt.ID
                         select clients;

            if (client.Count() > 0)
            {
                foreach (clients c in client)
                {
                    c.name = clnt.name;
                    c.pan_no = clnt.pan_no;
                    c.email = clnt.email;
                    c.contact_no = clnt.contact_no;
                    c.address = clnt.address;
                    c.bank_accountNo = clnt.bank_accountNo;
                    c.accountType = clnt.accountType;
                    c.aadhar_no = clnt.aadhar_no;
                    c.aadharLinkStatus = clnt.aadharLinkStatus;
                    c.group_id = clnt.group_id;
                    c.gstin = clnt.gstin;
                
                }
                db.SaveChanges();
                db.Dispose();
            }
            else
            {
                var client_new = new clients();
                client_new.name = clnt.name;
                client_new.pan_no = clnt.pan_no;
                client_new.email = clnt.email;
                client_new.contact_no = clnt.contact_no;
                client_new.address = clnt.address;
                client_new.bank_accountNo = clnt.bank_accountNo;
                client_new.accountType = clnt.accountType;
                client_new.aadhar_no = clnt.aadhar_no;
                client_new.aadharLinkStatus = clnt.aadharLinkStatus;
                client_new.group_id = clnt.group_id;
                client_new.gstin = clnt.gstin;

                db.clientss.Add(client_new);
                db.SaveChanges();
                db.Dispose();
                
            }
        }
    }
}
