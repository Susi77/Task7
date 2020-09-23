using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WEBAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employe>().HasData(
                new Employe { ID = 1, Name = "Name1" ,Surname = "Surname1",TelNo="+37477737606",Mail="susi.makaryan@gmail.com",Gender="Female",StartDate=DateTime.Now,FireDate=DateTime.UtcNow},
                new Employe { ID = 2, Name = "Name2" ,Surname = "Surname2", TelNo = "+37477737606", Mail = "susi.makaryan@gmail.com", Gender = "Female", StartDate = DateTime.Now, FireDate = DateTime.UtcNow },
                new Employe { ID = 3, Name = "Name3" ,Surname = "Surname3", TelNo = "+37477737606", Mail = "susi.makaryan@gmail.com", Gender = "Female", StartDate = DateTime.Now, FireDate = DateTime.UtcNow }
            );

            modelBuilder.Entity<Position>().HasData(
                new Position { ID = 1, Name = "Manager", WorkMail = "sdg@gmail.com", Perm =2, Max = 1000000 ,Min=150000},
                new Position { ID = 2, Name = "Sales", WorkMail = "ssff@gmail.com", Perm = 4, Max = 200000, Min = 50000 },
                new Position { ID = 3, Name = "Baker", WorkMail = "kadj@gmail.com", Perm = 6, Max = 150000, Min = 50000 }



            );

            modelBuilder.Entity<Staff>().HasData(
                new Staff { EmpID=1, PosID=1,Salary=150000},
                new Staff { EmpID = 2, PosID = 3, Salary = 140000 },
                new Staff { EmpID = 3, PosID =2 , Salary = 140000 }
             );
        }

    }
}
