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
    
    public partial class kpi_SetGoal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kpi_SetGoal()
        {
            this.kpi_PerfomanceRate = new HashSet<kpi_PerfomanceRate>();
        }
    
        public int KSG_ID { get; set; }
        public Nullable<int> KSG_UpGoal { get; set; }
        public Nullable<int> KSG_Status { get; set; }
        public Nullable<int> KSG_PerWeight { get; set; }
        public byte[] KSG_SetDate { get; set; }
        public string KSG_IPAdress { get; set; }
        public int KPY_ID { get; set; }
        public Nullable<int> KPM_ID { get; set; }
        public Nullable<int> KPK_ID { get; set; }
        public Nullable<int> KPL_ID { get; set; }
        public Nullable<int> ums_ID { get; set; }
    
        public virtual kpi_Perfomance kpi_Perfomance { get; set; }
        public virtual kpi_PerfomanceKey kpi_PerfomanceKey { get; set; }
        public virtual kpi_PerfomanceLevel kpi_PerfomanceLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kpi_PerfomanceRate> kpi_PerfomanceRate { get; set; }
        public virtual kpi_Year kpi_Year { get; set; }
        public virtual umsuser umsuser { get; set; }
    }
}
