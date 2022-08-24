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
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();
        }

        private void tbMaKH_TextChanged(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            TblKhachHang tblKhachHang = context.TblKhachHangs.FirstOrDefault(x => x.MaKh == tbMaKH.Text);
            if (tblKhachHang == null)
            {
                btnDatMua.Enabled = true;
                return;
            }
            tbTenKH.Text = tblKhachHang.TenHk;
            tbDiaChi.Text = tblKhachHang.Diachi;

            TblHoadon tblHoadon = context.TblHoadons.FirstOrDefault(x => x.MaKh == tblKhachHang.MaKh);
            if (tblHoadon == null)
            {
                tbMaHD.Text = "";
                tbNgayHD.Text = "";
                btnDatMua.Enabled = true;
                dataGridView.DataSource = "";
                return;
            }

            tbMaHD.Text = tblHoadon.MaHd.ToString();
            tbNgayHD.Text = tblHoadon.NgayHd.ToString();
            btnDatMua.Enabled = false;
            btnPhai.Enabled = true;
            btnTrai.Enabled = true;

            dataGridView.DataSource = context.TblChiTietHds
                .Select(item => new
                {
                    MaChiTietHoaDon = item.MaChiTietHd,
                    MaHoaDon = item.MaHd,
                    MatHang = context.TblMatHangs.FirstOrDefault(x => x.MaHang == item.MaHang).TenHang,
                    SoLuong = item.Soluong
                })
                .Where(x => x.MaHoaDon.ToString() == tbMaHD.Text).ToList();
        }

        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            TblKhachHang tblKhachHang = context.TblKhachHangs.FirstOrDefault(x => x.TenHk == tbTenKH.Text);
            if (tblKhachHang == null)
            {
                btnDatMua.Enabled = true;
                return;
            }
            tbMaKH.Text = tblKhachHang.MaKh;
            tbDiaChi.Text = tblKhachHang.Diachi;

            TblHoadon tblHoadon = context.TblHoadons.FirstOrDefault(x => x.MaKh == tblKhachHang.MaKh);
            if (tblHoadon == null)
            {
                btnDatMua.Enabled = true;
                tbMaHD.Text = "";
                tbNgayHD.Text = "";
                dataGridView.DataSource = "";
                return;
            }

            tbMaHD.Text = tblHoadon.MaHd.ToString();
            tbNgayHD.Text = tblHoadon.NgayHd.ToString();
            btnDatMua.Enabled = false;
            btnPhai.Enabled = true;
            btnTrai.Enabled = true;

            dataGridView.DataSource = context.TblChiTietHds
                .Select(item => new
                {
                    MaChiTietHoaDon = item.MaChiTietHd,
                    MaHoaDon = item.MaHd,
                    MatHang = context.TblMatHangs.FirstOrDefault(x=>x.MaHang==item.MaHang).TenHang,
                    SoLuong = item.Soluong
                })
                .Where(x => x.MaHoaDon.ToString() == tbMaHD.Text).ToList();
        }


        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            tbMaKH.Text = "";
            tbTenKH.Text = "";
            tbDiaChi.Text = "";
            tbMaHD.Text = "";
            tbNgayHD.Text = "";
            cbMatHang.Text = "";
            tbGia.Text = "";
            tbSoLuong.Text = "";
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            cbMatHang.DataSource = context.TblMatHangs.ToList();
            cbMatHang.DisplayMember = "TenHang";
            cbMatHang.ValueMember = "MaHang";
        }

        private void cbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            TblMatHang tblMatHang = context.TblMatHangs.FirstOrDefault(x => x.TenHang == cbMatHang.Text);
            if (tblMatHang == null) return;
            tbGia.Text = tblMatHang.Gia.ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaHD.Text = dataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            cbMatHang.Text = dataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            tbSoLuong.Text = dataGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            TblChiTietHd tblChiTietHd = context.TblChiTietHds
                .FirstOrDefault(x=>x.MaHang==cbMatHang.SelectedValue.ToString()
                && x.MaHd.ToString()==tbMaHD.Text);
            if (tblChiTietHd != null)
            {
                tblChiTietHd.Soluong += Convert.ToInt32(tbSoLuong.Text);
                loadData();
                context.SaveChanges();
                MessageBox.Show("Thêm thành công!");
                loadData();
                return;
            }
            else
            {
                try
                {
                    TblChiTietHd tblChiTietHd_new = new TblChiTietHd
                    {
                        MaChiTietHd = context.TblChiTietHds.Count()+1,
                        MaHd = Convert.ToInt32(tbMaHD.Text),
                        MaHang = cbMatHang.SelectedValue.ToString(),
                        Soluong = Convert.ToInt32(tbSoLuong.Text)
                    };
                    if (MessageBox.Show("Bạn có chắc là thêm mới một mặt hàng vào đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.TblChiTietHds.Add(tblChiTietHd_new);
                        context.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                        loadData();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập số lượng sai rồi!");
                }
            }
        }

        private void loadData()
        {
            MyOrderContext context = new MyOrderContext();
            dataGridView.DataSource = context.TblChiTietHds
            .Select(item => new
            {
                MaChiTietHoaDon = item.MaChiTietHd,
                MaHoaDon = item.MaHd,
                MatHang = context.TblMatHangs.FirstOrDefault(x => x.MaHang == item.MaHang).TenHang,
                SoLuong = item.Soluong
            })
            .Where(x => x.MaHoaDon.ToString() == tbMaHD.Text).ToList();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            if (MessageBox.Show("Bạn có chắc là muốn xóa đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TblChiTietHd tblChiTietHd_old = context.TblChiTietHds
                    .FirstOrDefault(x => x.MaHang == cbMatHang.SelectedValue.ToString()
                    && x.MaHd.ToString() == tbMaHD.Text);
                context.TblChiTietHds.Remove(tblChiTietHd_old);
                context.SaveChanges();

                List<TblChiTietHd> checkRemain = context.TblChiTietHds
                    .Where(x => x.MaHd.ToString() == tbMaHD.Text).ToList();
                if (checkRemain.Count() == 0)
                {
                    TblHoadon tblHoadon = context.TblHoadons.FirstOrDefault(x => x.MaHd.ToString() == tbMaHD.Text);
                    context.TblHoadons.Remove(tblHoadon);
                    context.SaveChanges();
                }
                MessageBox.Show("Xóa thành công!");
                loadData();
                return;
            }
            else
            {
                return;
            }
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

        private void btnDatMua_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MyOrderContext context = new MyOrderContext();
            if (MessageBox.Show("Bạn có chắc muốn thêm đơn hàng mới này?", "Thêm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TblHoadon tblHoadon = new TblHoadon
                {
                    MaHd = context.TblHoadons.Count() + 1,
                    MaKh = tbMaKH.Text,
                    NgayHd = now
                };
                tbMaHD.Text = tblHoadon.MaHd.ToString();
                tbNgayHD.Text = tblHoadon.NgayHd.ToString();
                context.TblHoadons.Add(tblHoadon);
                context.SaveChanges();
                TblChiTietHd tblChiTietHd = new TblChiTietHd
                {
                    MaChiTietHd = context.TblChiTietHds.Count()+1,
                    MaHd = context.TblHoadons.Count(),
                    MaHang = cbMatHang.SelectedValue.ToString(),
                    Soluong = Convert.ToInt32(tbSoLuong.Text)
                };
                cbMatHang.SelectedValue = tblChiTietHd.MaHang;
                tbSoLuong.Text = tblChiTietHd.Soluong.ToString();
                context.TblChiTietHds.Add(tblChiTietHd);
                context.SaveChanges();
                MessageBox.Show("Thêm thành công!");
                loadData();
            }
            else
            {
                return;
            }
        }
    }
}
