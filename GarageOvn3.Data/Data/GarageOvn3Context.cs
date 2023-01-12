using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GarageOvn3.Core;

namespace GarageOvn3.Data.Data
{
    public class GarageOvn3Context : DbContext
    {
        public GarageOvn3Context (DbContextOptions<GarageOvn3Context> options)
            : base(options)
        {
        }

        public DbSet<GarageOvn3.Core.Vehicle> Vehicle { get; set; } = default!;

        public DbSet<GarageOvn3.Core.Membership> Membership { get; set; } = default!;
    }
}
