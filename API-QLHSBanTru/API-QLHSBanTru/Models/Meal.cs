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
    
    public partial class Meal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meal()
        {
            this.DailyMenuDetails = new HashSet<DailyMenuDetail>();
        }
    
        public int MealID { get; set; }
        public string Name { get; set; }
        public System.TimeSpan Time { get; set; }
        public bool Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailyMenuDetail> DailyMenuDetails { get; set; }
    }
}
