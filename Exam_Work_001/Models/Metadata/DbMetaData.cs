using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam_Work_001.Models.Metadata
{
    public partial class SubjectType
    {
        public int SubjectId { get; set; }
        [Required,Display(Name ="Subject Name")]
        public string SubJect_Name { get; set; }
        [Required, Display(Name = "Subject Code")]
        public string Subject_Code { get; set; }
    }


    public partial class TeacherType
    {
        public int TeacherId { get; set; }
        [Required, Display(Name = "Teacher Name")]
        public string Teacher_Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string faculty { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Class Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime Class_StartDay { get; set; }
        public int SubjectId { get; set; }
        [Required]
        public string Picture { get; set; }

    }
}