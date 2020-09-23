using System.Text.Json.Serialization;

namespace WEBAPI.Models
{
    public class Staff
    {
        public int EmpID { get; set; }

        public int PosID { get; set; }

        public decimal Salary { get; set; }
        
        [JsonIgnore]
        public virtual Employe Employe { get; set; }

        public virtual Position Positions { get; set; }
    }
}
