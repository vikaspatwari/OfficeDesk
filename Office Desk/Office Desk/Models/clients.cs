namespace office_desk.Models
{
    /// <summary>
    /// This is data model class for clients
    /// Data Object of This class will be used to fetch/save data in the clients table in the database.
    /// </summary>
    public class clients
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string contact_no { get; set; }
        public string aadhar_no { get; set; }
        public string pan_no { get; set; }
        public string address { get; set; }

    }
}
