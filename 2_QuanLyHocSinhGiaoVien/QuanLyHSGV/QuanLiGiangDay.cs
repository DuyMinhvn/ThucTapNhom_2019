//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyHSGV
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuanLiGiangDay
    {
        public string magiaovien { get; set; }
        public string mamonhoc { get; set; }
        public string malop { get; set; }
        public Nullable<System.DateTime> ngaybatdau { get; set; }
        public Nullable<System.DateTime> ngayketthuc { get; set; }
        public string TietHoc { get; set; }
        public string DiaDiem { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual Lop Lop { get; set; }
        public virtual MonHoc MonHoc { get; set; }
    }
}
