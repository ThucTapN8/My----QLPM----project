//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectQLPhongMay
{
    using System;
    using System.Collections.Generic;
    
    public partial class phongmay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phongmay()
        {
            this.dieuchuyentrangthietbi = new HashSet<dieuchuyentrangthietbi>();
            this.dieuchuyentrangthietbi1 = new HashSet<dieuchuyentrangthietbi>();
            this.trangthietbi = new HashSet<trangthietbi>();
        }
    
        public string ma { get; set; }
        public string ten { get; set; }
        public Nullable<int> soluongbienche { get; set; }
        public Nullable<int> soluongthucte { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dieuchuyentrangthietbi> dieuchuyentrangthietbi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dieuchuyentrangthietbi> dieuchuyentrangthietbi1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trangthietbi> trangthietbi { get; set; }
    }
}
