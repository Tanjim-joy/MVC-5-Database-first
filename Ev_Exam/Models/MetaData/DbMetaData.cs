using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ev_Exam.Models.MetaData
{
    public enum Facultys { Science = 1, Arts, Commerce }
    public partial class @classType
    {
        public int ClassId { get; set; }
        [Required, StringLength (60), Display(Name="Subject Name")]
        public string Subject_Name { get; set; }
    }

    public partial class TeacherType
    {
        public int TeacherId { get; set; }
        [Required, StringLength(60), Display(Name = "Teacher Name")]
        public string Teacher_Name { get; set; }
        [Required, EnumDataType(typeof(Facultys)), Display(Name = "Faculty")]
        public int Faculty { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Class Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime ClassStartDate { get; set; }
        [Required,Display(Name ="Image")]
        public string Picture { get; set; }
    }
}