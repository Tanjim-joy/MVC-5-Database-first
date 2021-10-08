using SubjectWebApplictions.Models;
using SubjectWebApplictions.Models.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SubjectWebApplictions.ViewModels
{
    public class TeachersViewModel
    {
        public int TeacherId { get; set; }
        [Required, Display(Name = "Teacher Name")]
        public string Teacher_Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Faculty { get; set; }
        [Required]
        public HttpPostedFileBase Picture { get; set; }
        public int C_SubjectId_ { get; set; }

        public virtual Subject Subject { get; set; }

    }
}