using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetCoreWebTest.Models
{
    public class NetCoreWebTestContext : DbContext
    {
        public NetCoreWebTestContext (DbContextOptions<NetCoreWebTestContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreWebTest.Models.Movie> Movie { get; set; }
    }
}
