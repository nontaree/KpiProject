//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kpiTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class umsuser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public umsuser()
        {
            this.kpi_AbilityGrade = new HashSet<kpi_AbilityGrade>();
            this.kpi_AbilityRate = new HashSet<kpi_AbilityRate>();
            this.kpi_PerfomanceRate = new HashSet<kpi_PerfomanceRate>();
            this.kpi_SetGoal = new HashSet<kpi_SetGoal>();
        }
    
        public int ums_ID { get; set; }
        public string ums_Name { get; set; }
        public string ums_Surname { get; set; }
        public string ums_Login { get; set; }
        public string ums_Password { get; set; }
        public Nullable<int> umg_ID { get; set; }
        public string ums_FName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kpi_AbilityGrade> kpi_AbilityGrade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kpi_AbilityRate> kpi_AbilityRate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kpi_PerfomanceRate> kpi_PerfomanceRate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kpi_SetGoal> kpi_SetGoal { get; set; }
        public virtual umsgroup umsgroup { get; set; }
    }
}
