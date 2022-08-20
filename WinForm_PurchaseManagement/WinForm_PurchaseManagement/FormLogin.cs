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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MyOrderContext context = new MyOrderContext();
            TblUser u = context.TblUsers.FirstOrDefault(
                x => x.Username.Equals(tbUserName.Text) && x.Pass == Convert.ToInt32(tbPass.Text));
            if(u == null)
            {
                MessageBox.Show("Bạn nhập sai Tên hoặc Mật khẩu. Xin vui lòng kiểm tra lại.");
                return;
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công. Chào mừng bạn đã trở lại, "+u.Username+"!");
                FormMain formMain = new FormMain();
                formMain.FormClosed += new FormClosedEventHandler(FormMain_FormClosed);
                formMain.Show();
                this.Hide();
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            tbUserName.BackColor = Color.LightPink;
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            tbUserName.BackColor = default;
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            tbPass.BackColor = Color.LightPink;
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            tbPass.BackColor = default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
