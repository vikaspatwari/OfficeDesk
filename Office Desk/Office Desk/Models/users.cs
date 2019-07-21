using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Desk.Models
{
    /// <summary>
    /// This is the the data model for the table which will be used to store credentials of users of this application.
    /// </summary>
    public class users
    {
        public int ID { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string user_role { get; set; }

    }
}
