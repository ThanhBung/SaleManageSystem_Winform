using System;
using System.Collections.Generic;

#nullable disable

namespace WinForm_PurchaseManagement.Models
{
    public partial class TblChiTietHd
    {
        public decimal MaChiTietHd { get; set; }
        public decimal? MaHd { get; set; }
        public string MaHang { get; set; }
        public int? Soluong { get; set; }

        public virtual TblMatHang MaHangNavigation { get; set; }
        public virtual TblHoadon MaHdNavigation { get; set; }
    }
}
