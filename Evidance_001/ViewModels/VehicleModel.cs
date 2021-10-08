using Evidance_001.Models.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Evidance_001.ViewModels
{
    public class VehicleModel
    {
        public int VehicleId { get; set; }
        [Required, EnumDataType(typeof(VehicleTypes))]
        public VehicleType VehicleTypes { get; set; }
    }
}