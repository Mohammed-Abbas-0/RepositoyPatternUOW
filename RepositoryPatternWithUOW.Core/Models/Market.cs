using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.Models
{
    public class Vehicles
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string TypeOfVehicle { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? price { get; set; }
        public Owner Owner { get; set; }
        
    }
    public class Car:Vehicles
    {
        public int? Mators { get; set; }
        [NotMapped]
        public string MatorsName { get; set; }

    }
    public class Bus:Vehicles
    {
    }
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OwnerName { get; set; }

        [ForeignKey("CarID")]
        public List<Car> Cars { get; set; }
        public int? CarID { get; set; }
        
        [ForeignKey("BusID")]
        public List<Bus> Buses { get; set; }
        public int? BusID { get; set; }

    }
}
