//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblKhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKhachHang()
        {
            this.tblPhieuXuats = new HashSet<tblPhieuXuat>();
        }
    
        public int ma_kh { get; set; }
        public string ten_kh { get; set; }
        public string dia_chi { get; set; }
        public string sdt { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> quyen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhieuXuat> tblPhieuXuats { get; set; }
    }
}
