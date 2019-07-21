using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Desk.Models;

namespace Office_Desk.AppCode
{
    public class getClientDetails
    {
        public string getClientName(int client_id)
        {
            string client_name ="";
            OfficeDeskDB db = new OfficeDeskDB();
            var client = from clients in db.clientss
                         where clients.ID == client_id
                         select clients;
            if (client.Count() !=0)
            {
                foreach (clients c in client)
                {
                    client_name = c.name;
                }
            }
            return client_name;
        }
    }
}
