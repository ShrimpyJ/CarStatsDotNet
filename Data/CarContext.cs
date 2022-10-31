using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarSpecs.Models;

namespace CarSpecs.Data
{
    public class CarContext : DbContext
    {
        public CarContext (DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        //public DbSet<CarSpecs.Models.Car> Car { get; set; } = default!;
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
        }
    }
}
