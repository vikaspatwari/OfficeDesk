using System;

namespace office_desk.Models
{
    /// <summary>
    /// This is the data model class for the tasks which have been completed by user.
    /// Data Object of This class will be used to fetch/save data in the completestasks table in the database.
    /// </summary>
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
