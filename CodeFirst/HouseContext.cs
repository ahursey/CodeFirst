using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class HouseContext : DbContext
    {
        public HouseContext() : base("HouseDBConnectionString")
        {
            Database.SetInitializer<HouseContext>(new CreateDatabaseIfNotExists<HouseContext>());
        }

        public DbSet<House> Houses { get; set; }

    }
}
