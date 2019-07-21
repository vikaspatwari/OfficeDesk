using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Desk.Models;

namespace Office_Desk.AppCode
{
    public class getGroupDetails
    {
        public string getGroup(int groupID)
        {
            string groupName = "";
            OfficeDeskDB db = new OfficeDeskDB();
            var group = from groups in db.groupss
                        where groups.ID == groupID
                        select groups;
            if (group.Count() > 0)
            {
                foreach (groups g in group)
                {
                    groupName = g.group_name;
                }
            }
            return groupName;
        }
    }
}
