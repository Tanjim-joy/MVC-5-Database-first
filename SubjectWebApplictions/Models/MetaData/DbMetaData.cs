using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SubjectWebApplictions.Models.MetaData
{
    //public enum Facultys { Arts=1,Engineering, sciecnce, Commerce }
    public partial class SubjectType
    {
        public int SubjectId { get; set; }
        [Required,Display(Name ="Subjects Name")]
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
        [Required]
        public string Faculty { get; set; }
        [Required]
        public string Picture { get; set; }
        public int C_SubjectId_ { get; set; }
    }
}