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
    
    public partial class BangDiem
    {
        public string mahocsinh { get; set; }
        public string mamonhoc { get; set; }
        public string tenmonhoc { get; set; }
        public Nullable<double> diemmieng1 { get; set; }
        public Nullable<double> diemmieng2 { get; set; }
        public Nullable<double> diem15p { get; set; }
        public Nullable<double> diem1tiet { get; set; }
        public Nullable<double> diemhetmon { get; set; }
        public Nullable<double> diemtrungbinh { get; set; }
    
        public virtual HocSinh HocSinh { get; set; }
        public virtual MonHoc MonHoc { get; set; }
    }
}
