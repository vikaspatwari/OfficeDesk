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
        /// <param name="empID">employee id of user</param>
        public void updateTasks(currenttasks task)
        {

            OfficeDeskDB db = new OfficeDeskDB();
            var CD = db;
            var CT = from currenttaskss in db.currenttaskss
                     where currenttaskss.ID == task.ID
                     select currenttaskss;
            if (CT != null)
            {
                foreach (currenttasks ct in CT)
                {
                   
                    ct.DateOfAssignment = Convert.ToDateTime(task.DateOfAssignment);
                    ct.assignee = task.assignee;
                    ct.priority = task.priority;
                    ct.TaskDescription = task.TaskDescription;
                    ct.DocumentsSource = task.TaskDescription;
                    ct.assigner = task.assigner;
                    ct.status = task.status;
                    ct.remarks = task.remarks;
                    db.SaveChanges();
                }

            }
            else
            {
                currenttasks ct = new currenttasks();
                ct.DateOfAssignment = Convert.ToDateTime(task.DateOfAssignment);
                ct.assignee = task.assignee;
                ct.priority = task.priority;
                ct.TaskDescription = task.TaskDescription;
                ct.DocumentsSource = task.TaskDescription;
                ct.assigner = task.assigner;
                ct.status = task.status;
                ct.remarks = task.remarks;
            }
                    
        }
    }
}
