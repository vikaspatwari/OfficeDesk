using System;

namespace office_desk.Models
{
    /// <summary>
    /// This is the data model class for the tasks which are currently assigned to the users.
    /// Data Object of This class will be used to fetch/save data in the currenttasks table in the database.
    /// </summary>
    public class currenttasks
    {

        public int ID { get; set; }
        public int empId { get; set; }
        public DateTime DateOfAssignment { get; set; }
        public int ClientID { get; set; }
        public string SubjectWithParty { get; set; }
        public string areaOfWork { get; set; }
        public string priority { get; set; }
        public string TaskDescription { get; set; }
        public string DocumentsSource { get; set; }
        public string assigner { get; set; }
        public string assignee { get; set; }
        public string status { get; set; }
        public string remarks { get; set; }
    }
}
