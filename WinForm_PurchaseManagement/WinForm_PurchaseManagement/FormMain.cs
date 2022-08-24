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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void cậpNhậtDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.FormClosed += new FormClosedEventHandler(FormProduct_FormClosed);
            formProduct.Show();
            this.Hide();
        }

        private void FormProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void xửLýBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSale formSale = new FormSale();
            formSale.FormClosed += new FormClosedEventHandler(FormSale_FormClosed);
            formSale.Show();
            this.Hide();
        }

        private void FormSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.FormClosed += new FormClosedEventHandler(FormCustomer_FormClosed);
            formCustomer.Show();
            this.Hide();
        }

        private void FormCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void cậpNhậtHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.FormClosed += new FormClosedEventHandler(FormProduct_FormClosed);
            formProduct.Show();
            this.Hide();
        }

        private void xửLýBánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSale formSale = new FormSale();
            formSale.FormClosed += new FormClosedEventHandler(FormSale_FormClosed);
            formSale.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
