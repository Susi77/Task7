using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
namespace WEBAPI.Models
{
    public class HRContext : DbContext
    {
        public HRContext(DbContextOptions<HRContext> options): base (options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employe>().HasMany(c => c.Staffs).WithOne(e=>e.Employe).HasForeignKey(a => a.EmpID);


            modelBuilder.Entity<Position>().HasMany(c => c.Staffs).WithOne(p=>p.Positions).HasForeignKey(p=>p.PosID);

            modelBuilder.Entity<Employe>().HasMany(p=>p.Positions);

        }


        public DbSet<Employe> Employes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        
    }
}
