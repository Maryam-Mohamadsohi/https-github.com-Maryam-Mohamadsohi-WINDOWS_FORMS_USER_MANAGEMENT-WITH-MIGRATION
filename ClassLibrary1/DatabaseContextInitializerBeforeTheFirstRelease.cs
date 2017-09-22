using System.Data.Entity;
using System.Linq;

namespace Models
{
    internal class DatabaseContextInitializerBeforeTheFirstRelease :
        System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        public DatabaseContextInitializerBeforeTheFirstRelease()
        {

        }

        protected override void Seed(DatabaseContext databaseContext)
        {
            base.Seed(databaseContext);

            try
            {
                DatabaseContexInitializer.seed(databaseContext);
            }
            catch (System.Exception)
            {

            }
        }
    }
}
