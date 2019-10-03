using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFTesting.IntegrationTests
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) :
            base(options)
        {

        }
    }
}
