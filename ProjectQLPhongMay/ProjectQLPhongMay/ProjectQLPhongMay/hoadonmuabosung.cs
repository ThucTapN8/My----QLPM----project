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
    
    public partial class hoadonmuabosung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hoadonmuabosung()
        {
            this.chitiethoadonbosung = new HashSet<chitiethoadonbosung>();
        }
    
        public System.Guid ma { get; set; }
        public string hienthima { get; set; }
        public string nguoicap { get; set; }
        public Nullable<System.DateTime> ngaycap { get; set; }
        public Nullable<int> soluong { get; set; }
        public string mota { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitiethoadonbosung> chitiethoadonbosung { get; set; }
    }
}
