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
    
    public partial class record_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public record_tbl()
        {
            this.caseSubject_tbl = new HashSet<caseSubject_tbl>();
        }
    
        public int recordID { get; set; }
        public Nullable<int> recordNum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<caseSubject_tbl> caseSubject_tbl { get; set; }
    }
}