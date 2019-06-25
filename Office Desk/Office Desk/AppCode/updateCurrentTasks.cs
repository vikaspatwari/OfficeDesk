using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using office_desk.Models;

namespace Office_Desk.AppCode
{
    /// <summary>
    /// This class will be updating the current tasks for particular employee
    /// </summary>
    class updateCurrentTasks
    {
        /// <summary>
        /// method to update existing as well as new tasks.
        /// </summary>
        /// <param name="empID"></param>
        public void updateTasks(int taskID)
        {

            OfficeDeskDB db = new OfficeDeskDB();
            var CD = db;
            var CT = from currenttaskss in db.currenttaskss
                     where currenttaskss.ID == taskID orderby currenttaskss.ID
                     select currenttaskss;
            if (CT != null)
            {


            }
            else
            {

            }
                    
        }
    }
}
