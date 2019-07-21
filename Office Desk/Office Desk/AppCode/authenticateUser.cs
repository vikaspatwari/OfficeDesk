using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Desk.Models;

namespace Office_Desk.AppCode
{
    class authenticateUser
    {
        public bool check_user(string user_name, string user_password)
        {
            bool result;
            
            OfficeDeskDB db = new OfficeDeskDB();
            var user = from users in db.userss
                       where users.user_name == user_name && users.password == user_password
                       select users;
            
            if (user.Count() > 0)
            {
                foreach (users u in user)
                {
                    GlobalVar.app_userID = u.ID;
                }
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
            
    }
}
