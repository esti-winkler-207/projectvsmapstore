//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale_Time
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sale_Time()
        {
            this.prop = new HashSet<prop>();
            this.Updates = new HashSet<Updates>();
        }
    
        public int idSale { get; set; }
        public int storid { get; set; }
        public System.DateTime start { get; set; }
        public System.DateTime end { get; set; }
        public string saleName { get; set; }
        public string Describe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prop> prop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Updates> Updates { get; set; }
    }
}
