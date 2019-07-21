namespace Office_Desk.Models
{
    /// <summary>
    /// This is data model class for clients
    /// Data Object of This class will be used to fetch/save data in the clients table in the database.
    /// </summary>
    public class clients
    {
        public int ID { get; set; }
        public int group_id { get; set; }
        public string name { get; set; }
        public string contact_no { get; set; }
        public string email { get; set; }
        public string aadhar_no { get; set; }
        public string aadharLinkStatus { get; set; }
        public string gstin { get; set; }
        public string pan_no { get; set; }
        public string bank_accountNo { get; set; }
        public string accountType { get; set; }
        public string address { get; set; }

    }
}
