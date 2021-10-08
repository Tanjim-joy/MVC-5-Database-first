using Ev_Exam.Models;
using Ev_Exam.Models.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ev_Exam.ViewModel
{
    public class TeacherViewModel
    {
        public int TeacherId { get; set; }
        [Required, StringLength(60), Display(Name = "Teacher Name")]
        public string Teacher_Name { get; set; }
        [Required, EnumDataType(typeof(Facultys)), Display(Name = "Faculty")]
        public Facultys Faculty { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Class Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime ClassStartDate { get; set; }
        [Required, Display(Name = "Image")]
        public HttpPostedFileBase Picture { get; set; }
        public int ClassId { get; set; }

        public virtual Models.@class @class { get; set; }
    }
}