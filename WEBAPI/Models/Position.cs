using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Models
{
    public class Position
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string WorkMail { get; set; }

        public int Perm { get; set; }

        public decimal Max { get; set; }

        public decimal Min { get; set; }

        public virtual List<Staff> Staffs { get; set; }

        public virtual List<Employe> Employes { get; set; }

    }
}
