//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCuoiKyLTHDT
{
    using System;
    using System.Collections.Generic;
    
    public partial class DangKyO
    {
        public int MaDK { get; set; }
        public string Masv { get; set; }
        public string TenSV { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string GioiTinh { get; set; }
        public System.DateTime NgayVaoO { get; set; }
        public string SDT { get; set; }
        public string email { get; set; }
        public string MK { get; set; }
        public int Phg { get; set; }
        public string MaQL { get; set; }
    
        public virtual QuanLy QuanLy { get; set; }
    }
}
