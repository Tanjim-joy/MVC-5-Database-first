//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ev_Exam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public int TeacherId { get; set; }
        public string Teacher_Name { get; set; }
        public int Faculty { get; set; }
        public System.DateTime ClassStartDate { get; set; }
        public string Picture { get; set; }
        public int ClassId { get; set; }
    
        public virtual @class @class { get; set; }
    }
}