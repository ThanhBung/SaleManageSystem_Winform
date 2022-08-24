using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_PurchaseManagement.Models;

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
            if (MessageBox.Show("Bạn chắc chứ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            List<string> listMaH = new List<string>();
            Dictionary<string, int> d = new Dictionary<string, int>();
            List<TblChiTietHd> tblChiTietHds = context.TblChiTietHds.ToList();

            foreach (TblChiTietHd item in tblChiTietHds)
            {
                listMaH.Add(item.MaHang);
            }

            foreach (string i in listMaH)
            {
                if (d.ContainsKey(i))
                {
                    d[i]++;
                }
                else
                {
                    d[i] = 1;
                }
            }
            listMaH.Clear();
            string s = "";
            listMaH.Add("Tất cả MH");
            foreach (string item in d.Keys)
            {
                s += item + ",";
                listMaH.Add(item);
            }
            cbMaHang.DataSource = listMaH;
            
        }

        private void cbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            if(cbMaHang.Text == "Tất cả MH")
            {
                tbTenMH.Text = "";
                var data = context.TblChiTietHds.Join(
                context.TblHoadons,
                cthd => cthd.MaHd,
                hd => hd.MaHd,
                (cthd, hd) => new
                {
                    STT = cthd.MaChiTietHd,
                    MaHD = hd.MaHd,
                    MaHang = cthd.MaHang,
                    SoLuong = cthd.Soluong,
                    MaKH = hd.MaKh,
                    NgayHD = hd.NgayHd
                })
                .ToList();
                dataGridViewCus.DataSource = data;
            }
            else
            {
                tbTenMH.Text = context.TblMatHangs.FirstOrDefault(x => x.MaHang == cbMaHang.Text).TenHang;
                var data = context.TblChiTietHds.Join(
                    context.TblHoadons,
                    cthd => cthd.MaHd,
                    hd => hd.MaHd,
                    (cthd, hd) => new
                            {
                                STT = cthd.MaChiTietHd,
                                MaHD = hd.MaHd,
                                MaHang = cthd.MaHang,
                                SoLuong = cthd.Soluong,
                                MaKH = hd.MaKh,
                                NgayHD = hd.NgayHd
                            })
                    .Where(cthd => cthd.MaHang == cbMaHang.Text)
                    .ToList();
                dataGridViewCus.DataSource = data;
            }
        }

        private void cbMaHang_TextChanged(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            if (cbMaHang.Text == "Tất cả MH")
            {
                tbTenMH.Text = "";
                var data = context.TblChiTietHds.Join(
                context.TblHoadons,
                cthd => cthd.MaHd,
                hd => hd.MaHd,
                (cthd, hd) => new
                {
                    STT = cthd.MaChiTietHd,
                    MaHD = hd.MaHd,
                    MaHang = cthd.MaHang,
                    SoLuong = cthd.Soluong,
                    MaKH = hd.MaKh,
                    NgayHD = hd.NgayHd
                })
                .ToList();
                dataGridViewCus.DataSource = data;
            }
            if (context.TblMatHangs.FirstOrDefault(x => x.MaHang == cbMaHang.Text) != null)
            {
                tbTenMH.Text = context.TblMatHangs.FirstOrDefault(x => x.MaHang == cbMaHang.Text).TenHang;
                var data = context.TblChiTietHds.Join(
                    context.TblHoadons,
                    cthd => cthd.MaHd,
                    hd => hd.MaHd,
                    (cthd, hd) => new
                    {
                        STT = cthd.MaChiTietHd,
                        MaHD = hd.MaHd,
                        MaHang = cthd.MaHang,
                        SoLuong = cthd.Soluong,
                        MaKH = hd.MaKh,
                        NgayHD = hd.NgayHd
                    })
                    .Where(cthd => cthd.MaHang == cbMaHang.Text)
                    .ToList();
                dataGridViewCus.DataSource = data;
            }
        }

        private void dataGridViewCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaHang.Text = dataGridViewCus.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            if (dateTimePicker1.Value>dateTimePicker2.Value)
            {
                MessageBox.Show("Chọn ngày sai rồi");
                return;
            }
            else
            {
                if(cbMaHang.Text == "Tất cả MH")
                {
                    tbTenMH.Text = "";
                    var data = context.TblChiTietHds.Join(
                    context.TblHoadons,
                    cthd => cthd.MaHd,
                    hd => hd.MaHd,
                    (cthd, hd) => new
                    {
                        STT = cthd.MaChiTietHd,
                        MaHD = hd.MaHd,
                        MaHang = cthd.MaHang,
                        SoLuong = cthd.Soluong,
                        MaKH = hd.MaKh,
                        NgayHD = hd.NgayHd
                    })
                    .Where(hd => hd.NgayHD>=dateTimePicker1.Value && hd.NgayHD<=dateTimePicker2.Value)
                    .ToList();
                    dataGridViewCus.DataSource = data;
                }
            }
        }

        private void btnInBao_Click(object sender, EventArgs e)
        {

        }
    }
}
