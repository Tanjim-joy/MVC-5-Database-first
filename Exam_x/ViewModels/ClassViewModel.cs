using Exam_x.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam_x.ViewModels
{
    public class ClassViewModel
    {
        public int ClassId { get; set; }
        [Required, Display(Name ="Course Name")]
        public string Course_Name { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime StartDate { get; set; }
        public string Total_Houre { get; set; }
        [Required,Display(Name = "Teacher Name")]
        public Nullable<int> TeachersId { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}