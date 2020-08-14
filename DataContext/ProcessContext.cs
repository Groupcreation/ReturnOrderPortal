using Microsoft.EntityFrameworkCore;
using ReturnOrderPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReturnOrderPortal.DataContext
{
    public class ProcessContext : DbContext
    {
        public ProcessContext(DbContextOptions<ProcessContext> options) : base(options)
        {
        }
        public DbSet<ProcessResponse> ProcessDb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ProcessResponse>()
              //  .HasNoKey();
        }


    }
}
