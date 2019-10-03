using Microsoft.EntityFrameworkCore;
using System;

namespace EFTesting.UnitTests
{
    public class TestBase
    {
        protected MyContext GivenContext()
        {
            string databaseName = Guid.NewGuid().ToString();

            var context = new MyContext(new DbContextOptionsBuilder()
                .UseInMemoryDatabase(databaseName: databaseName)
                .Options);
            return context;
        }
    }
}