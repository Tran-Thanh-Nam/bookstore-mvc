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
    
    public partial class tblPhieuNhap
    {
        public int ma_pn { get; set; }
        public Nullable<int> ma_nv { get; set; }
        public Nullable<int> ma_ncc { get; set; }
        public Nullable<System.DateTime> ngay_nhap { get; set; }
    
        public virtual tblNCC tblNCC { get; set; }
        public virtual tblCTPhieuNhap tblCTPhieuNhap { get; set; }
    }
}
