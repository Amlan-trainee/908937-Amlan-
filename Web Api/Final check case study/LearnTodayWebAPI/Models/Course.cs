//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearnTodayWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }
        public string Description { get; set; }
        public string Trainer { get; set; }
        public System.DateTime Start_Date { get; set; }
        public Student Students { get; set; }
    }
}