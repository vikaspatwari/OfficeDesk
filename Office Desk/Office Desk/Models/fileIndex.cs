namespace office_desk.Models
{
    /// <summary>
    /// This is the data model class for the index of the physical files stored in the database.
    /// Data Object of This class will be used to fetch/save data in the fileindex table in the database.
    /// </summary>
    public class fileindex
    {
        public int ID { get; set; }
        public int FileNo { get; set; }
        public string FileAlphabet { get; set; }
        public int ClientID { get; set; }
        public int ClientKin { get; set; }
        public string FileCategory { get; set; }
        public string FileType { get; set; }
        public string FileStatus { get; set; }
        public string AssesseStatus { get; set; }
        public string FileYear { get; set; }
        public string ReturnStatus { get; set; }
        public string DateOfIncorporation { get; set; }
        public string remarks { get; set; }

    }
}
