//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FouziaApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class receiptOfCase_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public receiptOfCase_tbl()
        {
            this.case_tbl = new HashSet<case_tbl>();
        }
    
        public int rcID { get; set; }
        public Nullable<System.DateTime> rcDate { get; set; }
        public string rcJudicialAuthority { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<case_tbl> case_tbl { get; set; }
    }
}
