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
    
    public partial class caseSubject_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public caseSubject_tbl()
        {
            this.case_tbl = new HashSet<case_tbl>();
            this.persons_tbl = new HashSet<persons_tbl>();
        }
    
        public int csID { get; set; }
        public Nullable<int> csSec { get; set; }
        public Nullable<int> csIlot { get; set; }
        public Nullable<int> csLot { get; set; }
        public string csAdress { get; set; }
        public string csTown { get; set; }
        public Nullable<int> recordID { get; set; }
        public Nullable<int> catSubID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<case_tbl> case_tbl { get; set; }
        public virtual catSub_tbl catSub_tbl { get; set; }
        public virtual record_tbl record_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<persons_tbl> persons_tbl { get; set; }
    }
}
