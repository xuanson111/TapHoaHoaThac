//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiemTapHoa_WebNangCao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuNhap
    {
        public ChiTietPhieuNhap(int maPhieu, int maHH, double? soLuong, double? donGia)
        {
            MaPhieu = maPhieu;
            MaHH = maHH;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public int MaPhieu { get; set; }
        public int MaHH { get; set; }
        public Nullable<double> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
