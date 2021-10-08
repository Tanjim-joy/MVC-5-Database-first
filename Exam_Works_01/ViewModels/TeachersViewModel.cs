using Exam_Works_01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam_Works_01.ViewModels
{
    public class TeachersViewModel
    {
        public int TeacherId { get; set; }
        [Required, Display(Name = "Teacher Name")]
        public string Teacher_Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Class Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime ClassStartDate { get; set; }       
        public HttpPostedFileBase Picture { get; set; }
        [Required]
        public int SubjectId { get; set; }

    }
}