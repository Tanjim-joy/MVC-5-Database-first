using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam_x.Models.MetaData
{
    public enum Faculty { Science=1, Arts, Commerce }
    public partial class ClassType
    {
        public int ClassId { get; set; }
        [Required]
        public string Course_Name { get; set; }
        [Required]
        public System.DateTime StartDate { get; set; }
        [Required]
        public string Total_Houre { get; set; }
        [Required]
        public Nullable<int> TeachersId { get; set; }

    }
    public partial class TeacherType
    {
        public int TeachersId { get; set; }
        [Required]
        public string Teacher_Name { get; set; }
        [Required]
        public HttpPostedFileBase Picture { get; set; }
        [Required]
        public string Faculty { get; set; }
    }
}