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
    
    public partial class DailyTask
    {
        public int DailyTaskID { get; set; }
        public int StudentID { get; set; }
        public int WeeklyTaskID { get; set; }
        public int MonthlyTaskID { get; set; }
        public System.DateTime DateTask { get; set; }
        public bool Present { get; set; }
        public string Reason { get; set; }
        public System.TimeSpan DrugTime { get; set; }
        public double EatRating { get; set; }
        public double SleepRating { get; set; }
        public double HealthRating { get; set; }
        public double StudyRating { get; set; }
        public System.TimeSpan PickTime { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
    
        public virtual PhysicalMonthlyTask PhysicalMonthlyTask { get; set; }
        public virtual Student Student { get; set; }
        public virtual WeeklyTask WeeklyTask { get; set; }
    }
}
