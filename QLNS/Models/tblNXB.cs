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
    
    public partial class tblNXB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNXB()
        {
            this.tblSaches = new HashSet<tblSach>();
        }
    
        public int ma_nxb { get; set; }
        public string ten_nxb { get; set; }
        public string dia_chi { get; set; }
        public string email { get; set; }
        public string tt_nguoi_dai_dien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSach> tblSaches { get; set; }
    }
}
