using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamisignmentDll.Entities;

namespace GamisignmentDll.Context
{
    public class GamiSignmentContext : DbContext
    {
        public GamiSignmentContext() : base()
        {
            Database.SetInitializer(new GamiDbInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Repeat> Repeats { get; set; }


    }
}
