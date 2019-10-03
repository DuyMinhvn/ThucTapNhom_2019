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
    
    public partial class HocSinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocSinh()
        {
            this.BangDiems = new HashSet<BangDiem>();
            this.KetQuaHocTaps = new HashSet<KetQuaHocTap>();
        }
    
        public string mahocsinh { get; set; }
        public string hocvaten { get; set; }
        public Nullable<System.DateTime> ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string tongiao { get; set; }
        public string quequan { get; set; }
        public string diachithuongtru { get; set; }
        public string hotenbo { get; set; }
        public string nghenghiepbo { get; set; }
        public string hotenme { get; set; }
        public string nghenghiepme { get; set; }
        public string sodienthoai { get; set; }
        public string malop { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangDiem> BangDiems { get; set; }
        public virtual Lop Lop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KetQuaHocTap> KetQuaHocTaps { get; set; }
    }
}
