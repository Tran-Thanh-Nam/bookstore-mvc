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
    
    public partial class tblCTPhieuXuat
    {
        public int ma_px { get; set; }
        public Nullable<int> ma_sach { get; set; }
        public Nullable<int> so_luong { get; set; }
        public Nullable<int> don_gia { get; set; }
    
        public virtual tblPhieuXuat tblPhieuXuat { get; set; }
    }
}
