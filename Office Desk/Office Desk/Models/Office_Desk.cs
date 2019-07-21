using System.Data.Entity;

namespace Office_Desk.Models
{

    /// <summary>
    /// This class represents the schema of the database office_desk
    /// Data Object of This class will be used to fetch/save data from various tables in the database.
    /// </summary>
    public class OfficeDeskDB : DbContext
    {
        public OfficeDeskDB() : base("Office_desk")
        {
        }
      
        public DbSet<clients> clientss { get; set; }
        public DbSet<completedtasks> completedtaskss { get; set; }
        public DbSet<currenttasks> currenttaskss { get; set; }
        public DbSet<fileindex> fileindexs { get; set; }
        public DbSet<returnfilling> returnfillings { get; set; }
        public DbSet<users> userss { get; set; }
        public DbSet<userRoles> userRoless { get; set; }
        public DbSet<groups> groupss { get; set; }
       
    }
   
}
