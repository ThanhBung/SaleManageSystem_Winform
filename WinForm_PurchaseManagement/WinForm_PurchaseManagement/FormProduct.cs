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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            MyOrderContext context = new MyOrderContext();
            var data = context.TblMatHangs
                .Select(item => new
                {
                    MaHang = item.MaHang,
                    TenHang = item.TenHang,
                    DVT = item.Dvt,
                    Gia = item.Gia 
                })
                .ToList();
            dataGridViewCus.DataSource = data;

            cbDonViTinh.DataSource = new List<string>
            {
                "Cai",
                "Quyen",
                "Chiec",
                "Hop",
            };
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            tbMaHang.Text = dataGridViewCus.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            tbMaHangCu.Text = dataGridViewCus.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            tbTenHang.Text = dataGridViewCus.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            cbDonViTinh.Text = dataGridViewCus.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            tbGiaBan.Text = dataGridViewCus.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
        }

        private void Clear()
        {
            tbMaHang.Text = "";
            tbMaHangCu.Text = "";
            tbTenHang.Text = "";
            cbDonViTinh.Text = "";
            tbGiaBan.Text = "";
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            //Clear
            Clear();
            // Setting
            tbMaHang.Enabled = true;
            tbTenHang.Enabled = true;
            cbDonViTinh.Enabled = true;
            tbGiaBan.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(tbMaHang.Text.Trim()=="" || tbTenHang.Text.Trim()==""
                || cbDonViTinh.Text.Trim()=="" || tbGiaBan.Text.Trim()=="")
            {
                MessageBox.Show("Nhập sai rồi!");
                return;
            }
            else
            {
                MyOrderContext context = new MyOrderContext();
                TblMatHang tblMatHang_old = context.TblMatHangs
                    .FirstOrDefault(x=>x.MaHang==tbMaHang.Text.Trim());
                if(tblMatHang_old != null)
                {
                    MessageBox.Show("MaHang này đã tồn tại!");
                    return;
                }
                else
                {
                    try
                    {
                        TblMatHang tblMatHang_new = new TblMatHang
                        {
                            MaHang = tbMaHang.Text,
                            TenHang = tbTenHang.Text,
                            Dvt = cbDonViTinh.Text,
                            Gia = Convert.ToInt32(tbGiaBan.Text)
                        };
                        context.TblMatHangs.Add(tblMatHang_new);
                        context.SaveChanges();
                        Clear();
                        MessageBox.Show("Thêm thành công!");
                        LoadData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nhập sai rồi!");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            tbMaHang.Enabled = true;
            tbTenHang.Enabled = true;
            cbDonViTinh.Enabled = true;
            tbGiaBan.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (tbMaHang.Text.Trim() == "" || tbTenHang.Text.Trim() == ""
                || cbDonViTinh.Text.Trim() == "" || tbGiaBan.Text.Trim() == "")
            {
                MessageBox.Show("Nhập sai rồi!");
                return;
            }
            else
            {
                try
                {
                    MyOrderContext context = new MyOrderContext();
                    TblMatHang tblMatHang_new = context.TblMatHangs
                        .FirstOrDefault(x => x.MaHang == tbMaHangCu.Text);
                    tblMatHang_new.MaHang = tbMaHang.Text;
                    tblMatHang_new.TenHang = tbTenHang.Text;
                    tblMatHang_new.Dvt = cbDonViTinh.Text;
                    tblMatHang_new.Gia = Convert.ToInt32(tbGiaBan.Text);
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                catch(Exception)
                {
                    MessageBox.Show("Nhập sai rồi!");
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            TblChiTietHd cus = context.TblChiTietHds
                .FirstOrDefault(x => x.MaHang.ToLower().Equals(tbMaHang.Text.ToLower().Trim()));
            if (cus != null)
            {
                MessageBox.Show("Không thể xóa! Mặt hàng này nằm trong hóa đơn chi tiết.");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc xóa mặt hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    context.TblMatHangs.Remove(context.TblMatHangs
                        .FirstOrDefault(x => x.MaHang.ToLower().Equals(tbMaHang.Text.ToLower().Trim()))
                        );
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
