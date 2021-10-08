using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Evidance_001.Models.Metadata
{
    public enum VehicleTypes { LightWeight =1, MediumWeight=2, HevyWeight=3 }
    public partial class CarType
    {
        
        public int CarId { get; set; }
        [Required, Display(Name ="Car Model")]
        public string CarModel { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Manufacure Date")]
        public System.DateTime ManufacureDate { get; set; }
        [Required]
        public decimal Price_ { get; set; }
        [Required]
        public string Picture { get; set; }
        public int VehicleId { get; set; }
    }
    public partial class VehicleType
    {
        public int VehicleId { get; set; }
        [Required, EnumDataType(typeof(VehicleTypes))]
        public int VehicleTypes { get; set; }
    }

    
}