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
    
    public partial class kpi_Perfomance
    {

        public kpi_Perfomance()
        {
            this.kpi_PerfomanceKey = new HashSet<kpi_PerfomanceKey>();
            this.kpi_SetGoal = new HashSet<kpi_SetGoal>();
        }
    
        public int KPM_ID { get; set; }
        public string KPM_Event { get; set; }
        public Nullable<int> KPM_FPercent { get; set; }
        public Nullable<int> KPM_SPercent { get; set; }
        public Nullable<int> KPY_ID { get; set; }
    
        public virtual kpi_Year kpi_Year { get; set; }
        
        public virtual ICollection<kpi_PerfomanceKey> kpi_PerfomanceKey { get; set; }
        
        public virtual ICollection<kpi_SetGoal> kpi_SetGoal { get; set; }
        public int KPK_ID { get; internal set; }
        public object KPK_Number { get; internal set; }
        public string KPK_Name { get; internal set; }
        public string KPK_Comment { get; internal set; }
        public string KPY_Name { get; internal set; }
        public DateTime? KPY_StartDate { get; internal set; }
        public DateTime? KPY_EndDate { get; internal set; }
        
    }
}
