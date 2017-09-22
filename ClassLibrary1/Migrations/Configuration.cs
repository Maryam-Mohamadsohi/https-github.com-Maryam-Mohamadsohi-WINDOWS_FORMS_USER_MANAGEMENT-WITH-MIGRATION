namespace Models.Migrations
{
    
    using System.Data.Entity;
    using System.Linq;

    internal sealed class Configuration : 
        System.Data.Entity.Migrations.DbMigrationsConfiguration<Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "Models.DatabaseContext";
        }

        protected override void Seed(Models.DatabaseContext databaseContext)
        {
            base.Seed(databaseContext);

            if (databaseContext.Users.Count()!=0)
            {
                return;
            }

            try
            {
                DatabaseContexInitializer.seed(databaseContext);
            }
            catch (System.Exception)
            {

            }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
