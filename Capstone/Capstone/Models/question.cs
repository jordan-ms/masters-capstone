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
    
    public partial class question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public question()
        {
            this.options = new HashSet<option>();
            this.responses = new HashSet<respons>();
        }
    
        public int id { get; set; }
        public int hospital_id { get; set; }
        public string user_id { get; set; }
        public string text { get; set; }
        public bool active { get; set; }
        public bool free_text_field { get; set; }
        public bool multiple_choice { get; set; }
        public System.DateTime created_on { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual hospital hospital { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<option> options { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<respons> responses { get; set; }
    }
}