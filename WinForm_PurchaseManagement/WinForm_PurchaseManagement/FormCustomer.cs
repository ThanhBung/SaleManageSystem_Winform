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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            MyOrderContext context = new MyOrderContext();
            var data = context.TblKhachHangs
                .Select(item => new
                {
                    MaKH = item.MaKh,
                    TenKH = item.TenHk,
                    Gioitinh = item.Gt==true?"Nam":"Nữ",
                    Diachi = item.Diachi,
                    Ngaysinh = item.NgaySinh
                })
                .ToList();
            dataGridViewCus.DataSource = data;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaKH.Text = dataGridViewCus.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            tbTenKH.Text = dataGridViewCus.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            if (dataGridViewCus.Rows[e.RowIndex].Cells[2].FormattedValue.ToString()=="Nam")
            {
                radBtnNam.Checked = true;
            }
            else
            {
                radBtnNu.Checked = true;
            }
            tbDiaChi.Text = dataGridViewCus.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            tbDob.Text = dataGridViewCus.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            //Clear
            Clear();
            // Setting
            tbTenKH.Enabled = true;
            radBtnNam.Enabled = true;
            radBtnNu.Enabled = true;
            tbDob.Enabled = true;
            tbDiaChi.Enabled = true;
        }

        private void Clear()
        {
            tbMaKH.Text = "";
            tbTenKH.Text = "";
            radBtnNam.Checked = false;
            radBtnNu.Checked = false;
            tbDob.Text = "";
            tbDiaChi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbTenKH.Enabled == false)
            {
                MessageBox.Show("Bấm 'Mới' trước!");
                return;
            }
            else
            {
                MyOrderContext context = new MyOrderContext();
                TblKhachHang cus = context.TblKhachHangs
                    .FirstOrDefault(x => x.MaKh.ToLower().Equals(tbMaKH.Text.ToLower().Trim()));
                if(cus != null)
                {
                    MessageBox.Show("'MaKH' này đã tồn tại!");
                    return;
                }
                else
                {
                    try
                        {
                         TblKhachHang cus_new = new TblKhachHang
                         {
                             MaKh = "KH"+context.TblKhachHangs.Count(),
                             TenHk = tbTenKH.Text,
                             Gt = radBtnNam.Checked,
                             Diachi = tbDiaChi.Text,
                             NgaySinh = Convert.ToDateTime(tbDob.Text)
                         };
                         context.TblKhachHangs.Add(cus_new);
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
            if(tbMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Chọn 1 KH để sửa!");
                return;
            }
            else
            {
                // Setting
                tbTenKH.Enabled = true;
                radBtnNam.Enabled = true;
                radBtnNu.Enabled = true;
                tbDob.Enabled = true;
                tbDiaChi.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (tbMaKH.Text.Trim() == "" || tbTenKH.Enabled==false)
            {
                MessageBox.Show("Bấm 'Sửa' trước!");
                return;
            }
            else
            {
                MyOrderContext context = new MyOrderContext();
                TblKhachHang cus = context.TblKhachHangs
                    .FirstOrDefault(x => x.MaKh.ToLower().Equals(tbMaKH.Text.ToLower().Trim()));
                try
                {
                    cus.TenHk = tbTenKH.Text.Trim();
                    cus.Gt = radBtnNam.Checked;
                    cus.Diachi = tbDiaChi.Text.Trim();
                    cus.NgaySinh = Convert.ToDateTime(tbDob.Text.Trim());
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai rồi!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaKH.Text.Trim() == "" || tbTenKH.Enabled == false)
            {
                MessageBox.Show("Bấm 'Sửa' trước!");
                return;
            }
            else
            {
                MyOrderContext context = new MyOrderContext();
                TblHoadon cus = context.TblHoadons
                    .FirstOrDefault(x => x.MaKh.ToLower().Equals(tbMaKH.Text.ToLower().Trim()));
                if(cus != null)
                {
                    MessageBox.Show("Không thể xóa! Khách hàng này nằm trong hóa đơn.");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.TblKhachHangs.Remove(context.TblKhachHangs
                            .FirstOrDefault(x => x.MaKh.ToLower().Equals(tbMaKH.Text.ToLower().Trim()))
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
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
