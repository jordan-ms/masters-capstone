//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capstone.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuditEntry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuditEntry()
        {
            this.AuditEntryProperties = new HashSet<AuditEntryProperty>();
        }
    
        public int AuditEntryID { get; set; }
        public string EntitySetName { get; set; }
        public string EntityTypeName { get; set; }
        public int State { get; set; }
        public string StateName { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditEntryProperty> AuditEntryProperties { get; set; }
    }
}