using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Models
{
    public class Employe
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string TelNo { get; set; }

        public string Mail { get; set; }

        public string Gender { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FireDate { get; set; }

        public virtual List<Staff> Staffs { get; set; }

        public virtual List<Position> Positions { get; set; }

    }
}
