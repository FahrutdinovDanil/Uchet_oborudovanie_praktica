//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquipmentAccounting.bd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Technical_inspection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Technical_inspection()
        {
            this.Breakdown_during_inspection = new HashSet<Breakdown_during_inspection>();
        }
    
        public int Id_inspection { get; set; }
        public Nullable<System.DateTime> Date_inspection { get; set; }
        public string Result { get; set; }
        public Nullable<int> Id_employee { get; set; }
        public Nullable<int> Id_equipment { get; set; }
        public Nullable<bool> Done { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Breakdown_during_inspection> Breakdown_during_inspection { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
