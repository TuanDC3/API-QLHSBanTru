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
    
    public partial class HealthExaminationDetail
    {
        public int HealthExaminationDetailID { get; set; }
        public int HealthExaminationID { get; set; }
        public int StudentID { get; set; }
        public int HealthInsurance { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Eyes { get; set; }
        public string ENT { get; set; }
        public string InternalMedicine { get; set; }
        public string Oral { get; set; }
        public string Surgery { get; set; }
        public string Dermatology { get; set; }
        public string BoneMuscle { get; set; }
        public string Nerve { get; set; }
        public string Endocrine { get; set; }
        public string Other { get; set; }
        public string Note { get; set; }
        public double Rating { get; set; }
        public bool Status { get; set; }
    
        public virtual HealthExamination HealthExamination { get; set; }
        public virtual Student Student { get; set; }
    }
}
