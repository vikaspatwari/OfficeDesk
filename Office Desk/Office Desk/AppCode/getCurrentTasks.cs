using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using office_desk.Models;

namespace office_desk.AppCode
{
    // this class will be used to get the current tasks
    class getCurrentTasks
    {
        /// <summary>
        /// This function returs the current tasks which are assigned to the user
        /// </summary>
        /// <param name="empID"> The employee ID of the user</param>
        /// <returns></returns>
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
 