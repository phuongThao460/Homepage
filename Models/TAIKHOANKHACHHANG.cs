//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homepage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAIKHOANKHACHHANG
    {
        public int ID_KHACHHANG { get; set; }
        public string TEN_DANGNHAP { get; set; }
        public string MATKHAU { get; set; }
        public string ANH_DAIDIEN { get; set; }
        public Nullable<int> ID_LOAITK { get; set; }
        public Nullable<int> ID_TTKH { get; set; }
    
        public virtual LOAITAIKHOAN LOAITAIKHOAN { get; set; }
        public virtual THONGTINKHACHHANG THONGTINKHACHHANG { get; set; }
    }
}
