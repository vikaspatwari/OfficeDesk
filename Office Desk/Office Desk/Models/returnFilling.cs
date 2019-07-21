using System;

namespace Office_Desk.Models
{
    /// <summary>
    /// This is the data model class for the information about financial returns filed by clients.
    /// Data Object of This class will be used to fetch/save data in the returnfilling table in the database.
    /// </summary>
    public class returnfilling
    {
        public int ID { get; set; }
        public int ClientId { get; set; }
        public string AsessmentYear { get; set; }
        public DateTime DateOfFilling { get; set; }
        public DateTime DateOfDispatch { get; set; }
        public string PrAckNo { get; set; }
        public string EvcStatus{ get; set; }
        public string remarks { get; set; }
    }
}
