using System.Data.Entity;

namespace Office_Desk.Models
{
    //class representing database model
    class OfficeDeskDB : DbContext
    {
        public DbSet<clients> clientss { get; set; }
        public DbSet<completedtasks> completedtaskss { get; set; }
        public DbSet<currenttasks> currenttaskss { get; set; }
        public DbSet<fileindex> fileindexs { get; set; }
        public DbSet<returnfilling> returnfillings { get; set; }
    }
}
