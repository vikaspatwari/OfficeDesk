using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Desk.Models;

namespace Office_Desk.AppCode
{
    public class getUserDetails
    {
        public int determineUserID(string user_name)
        {
            int user_ID = 0;
            OfficeDeskDB db = new OfficeDeskDB();
            var user = from users in db.userss
                     where users.user_name == user_name
                      select users;
            if (user.Count() == 1)
            {
                foreach ( users u in user)
                {
                    user_ID = u.ID;
                }
            }
            return user_ID;
        }
    }
}
