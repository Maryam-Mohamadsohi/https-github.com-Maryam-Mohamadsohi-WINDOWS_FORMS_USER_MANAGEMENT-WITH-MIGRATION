using System.Data.Entity;
using System.Linq;

namespace Models
{
    internal static class DatabaseContexInitializer
    {
        static DatabaseContexInitializer()
        {

        }

        internal static void seed(DatabaseContext databaseContext)
        {
            Models.User oAdminUser = new Models.User();

            oAdminUser.IsAdmin = true;
            oAdminUser.IsActive = true;

            oAdminUser.Username = "Dariush";
            oAdminUser.Password = "1234512345";
            oAdminUser.FullName = "Mr. Dariush Tasdighi";

            databaseContext.Users.Add(oAdminUser);
        }
    }
}
