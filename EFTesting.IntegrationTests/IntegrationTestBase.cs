using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace EFTesting.IntegrationTests
{
    public class IntegrationTestBase
    {
        private const string DatabaseName = "MyDatabase";

        protected static MyContext GivenContext(bool beginTransaction = true)
        {
            var context = new MyContext(new DbContextOptionsBuilder()
                .UseSqlServer(ApplicationDatabase.ConnectionString)
                .Options);
            if (beginTransaction)
                context.Database.BeginTransaction();
            return context;
        }

        private static SqlConnectionStringBuilder ApplicationDatabase =>
            new SqlConnectionStringBuilder
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = DatabaseName,
                IntegratedSecurity = true
            };
    }
}