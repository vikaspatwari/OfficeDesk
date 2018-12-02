using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Desk.Models
{
    public class completed_tasks
    {
        public int ID { get; set; }
        public DateTime DateOfAssignment { get; set; }
        public DateTime DateOfCompletion { get; set; }
        public int ClientID { get; set; }
        public string TaskDescription { get; set; }
        public string assigner { get; set; }
        public string assignee { get; set; }
        public string status { get; set; }
        public string FeeStatus { get; set; }
        public string remarks { get; set; }
    }
}
