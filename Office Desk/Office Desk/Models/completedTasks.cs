using System;

namespace office_desk.Models
{
    public class completedtasks
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
