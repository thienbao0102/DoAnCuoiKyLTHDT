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
    
    public partial class QuanLy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuanLy()
        {
            this.DangKyOes = new HashSet<DangKyO>();
        }
    
        public string MaQL { get; set; }
        public string Ten { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyO> DangKyOes { get; set; }
    }
}