using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamWork_00.Models.Metadata
{
    public partial class SubjectType
    {
        public int SubjectId { get; set; }
        [Required, Display(Name = "Subjects Name")]
        public string Sub_Name { get; set; }
        [Required, Display(Name = "Subjects Code")]
        public string Sub_Code { get; set; }
    }

    public partial class TeacherType
    {
        public int TeacherId { get; set; }
        [Required, Display(Name = "Teacher Name")]
        public string Teacher_Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Class Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime ClassStartDate { get; set; }

        public string Picture { get; set; }
        [Required]
        public int SubjectId { get; set; }
    }
}