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
    
    public partial class kpi_Ability
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kpi_Ability()
        {
            this.kpi_AbilitySet = new HashSet<kpi_AbilitySet>();
        }
    
        public int KAB_ID { get; set; }
        public string KAB_Desc { get; set; }
        public string KAB_Comment { get; set; }
        public Nullable<int> KAB_Group { get; set; }
        public Nullable<int> KAP_ID { get; set; }
    
        public virtual kpi_AbilityType kpi_AbilityType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kpi_AbilitySet> kpi_AbilitySet { get; set; }
    }
}