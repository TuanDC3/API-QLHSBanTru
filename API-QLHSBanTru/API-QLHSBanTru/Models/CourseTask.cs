//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_QLHSBanTru.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseTask
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public double PhysicalRating { get; set; }
        public double StudyRating { get; set; }
        public double TotalRating { get; set; }
        public bool Passes { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
