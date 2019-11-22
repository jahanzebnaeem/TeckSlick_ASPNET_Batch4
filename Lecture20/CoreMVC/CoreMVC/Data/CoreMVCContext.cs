using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC.Models
{
    public class CoreMVCContext : DbContext
    {
        public CoreMVCContext (DbContextOptions<CoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<CoreMVC.Models.Country> Country { get; set; }
    }
}
