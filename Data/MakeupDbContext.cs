using MakeupAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeupAPI.Data
{
    public class MakeupDbContext: DbContext
    {

        public MakeupDbContext(DbContextOptions<MakeupDbContext> options)
               : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Brand> Quotes { get; set; }

    }
}
