﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WinForm_PurchaseManagement.Models
{
    public partial class TblHoadon
    {
        public TblHoadon()
        {
            TblChiTietHds = new HashSet<TblChiTietHd>();
        }

        public decimal MaHd { get; set; }
        public string MaKh { get; set; }
        public DateTime? NgayHd { get; set; }

        public virtual TblKhachHang MaKhNavigation { get; set; }
        public virtual ICollection<TblChiTietHd> TblChiTietHds { get; set; }
    }
}
