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
    
    public partial class kpi_Total
    {
        public int KPTT_ID { get; set; }
        public Nullable<int> KPTT_PerTotal { get; set; }
        public Nullable<int> KPTT_Percent { get; set; }
        public string KPTT_AbliTotal { get; set; }
        public Nullable<int> KPY_ID { get; set; }
    
        public virtual kpi_Year kpi_Year { get; set; }
    }
}
