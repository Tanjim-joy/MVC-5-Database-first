using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Evidance_001.ViewModels
{
    public class CarViewModel
    {
        public int CarId { get; set; }
        [Required, Display(Name = "Car Model")]
        public string CarModel { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Manufacure Date")]
        public System.DateTime ManufacureDate { get; set; }
        [Required]
        public decimal Price_ { get; set; }
        
        public HttpPostedFileBase Picture { get; set; }
        public int VehicleId { get; set; }
    }
}