//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.VIETSACHes = new HashSet<VIETSACH>();
        }
    
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public Nullable<decimal> GiaBan { get; set; }
        [AllowHtml]
        public string MoTa { get; set; }
        public string AnhBia { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public Nullable<int> MaCD { get; set; }
        public Nullable<int> MaNXB { get; set; }
    
        public virtual CHUDE CHUDE { get; set; }
        public virtual NHAXUATBAN NHAXUATBAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIETSACH> VIETSACHes { get; set; }
    }
}
