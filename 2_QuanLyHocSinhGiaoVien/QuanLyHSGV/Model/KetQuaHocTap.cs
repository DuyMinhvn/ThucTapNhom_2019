//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyHSGV.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class KetQuaHocTap
    {
        public string mahocsinh { get; set; }
        public string malop { get; set; }
        public Nullable<double> diemtrungbinhki1 { get; set; }
        public string hoclucki1 { get; set; }
        public Nullable<double> diemtrungbinhki2 { get; set; }
        public string hoclucki2 { get; set; }
        public Nullable<double> diemtrungbinhcanam { get; set; }
        public string hocluccanam { get; set; }
    
        public virtual HocSinh HocSinh { get; set; }
        public virtual Lop Lop { get; set; }
    }
}
