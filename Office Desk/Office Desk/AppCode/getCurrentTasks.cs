using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Desk.Models;

namespace Office_Desk.AppCode
{
    // this class will be used to get the current tasks
    class getCurrentTasks
    {

        public IEnumerable<currenttasks> getTasks(int empID)
        {
            OfficeDeskDB db = new OfficeDeskDB();
            var CD = db;
             var CT = from currenttaskss in db.currenttaskss
                                                      where currenttaskss.empId == empID
                                                      select currenttaskss;
            
            return CT;
        }  
    }
}
 