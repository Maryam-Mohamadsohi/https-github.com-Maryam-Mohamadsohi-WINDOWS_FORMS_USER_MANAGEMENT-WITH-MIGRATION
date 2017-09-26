namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        static DatabaseContext()
        {
            ////First Scenario***********************
            //System.Data.Entity.Database.SetInitializer
            //    (new DatabaseContextInitializerBeforeTheFirstRelease());
            ////First Scenario***********************

            //Second Scenario***********************
            System.Data.Entity.Database.SetInitializer
                (new System.Data.Entity.MigrateDatabaseToLatestVersion
                    <DatabaseContext, Migrations.Configuration>());
            //Second Scenario***********************
        }

        public DatabaseContext() : base()
        {

        }

        public System.Data.Entity.DbSet<User> Users { get; set; }
    }
}
