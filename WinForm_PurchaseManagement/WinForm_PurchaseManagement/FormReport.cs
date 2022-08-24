using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_PurchaseManagement
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //select MaChiTietHD, cthd.MaHD,MaHang,Soluong, MaKH, NgayHD from tblChiTietHD cthd
        //inner join tblHoadon hd on cthd.MaHD = hd.MaHD
    }
}
