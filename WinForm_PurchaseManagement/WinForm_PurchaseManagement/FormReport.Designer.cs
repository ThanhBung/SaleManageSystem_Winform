
namespace WinForm_PurchaseManagement
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTenMH = new System.Windows.Forms.TextBox();
            this.cbMaHang = new System.Windows.Forms.ComboBox();
            this.tbGiaBan = new System.Windows.Forms.TextBox();
            this.tbTuNgay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInBao = new System.Windows.Forms.Button();
            this.dataGridViewCus = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(216, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH SỬ BÁN HÀNG";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbTenMH);
            this.panel1.Controls.Add(this.cbMaHang);
            this.panel1.Controls.Add(this.tbGiaBan);
            this.panel1.Controls.Add(this.tbTuNgay);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 112);
            this.panel1.TabIndex = 1;
            // 
            // tbTenMH
            // 
            this.tbTenMH.Enabled = false;
            this.tbTenMH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbTenMH.Location = new System.Drawing.Point(402, 20);
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.Size = new System.Drawing.Size(252, 27);
            this.tbTenMH.TabIndex = 13;
            // 
            // cbMaHang
            // 
            this.cbMaHang.FormattingEnabled = true;
            this.cbMaHang.Location = new System.Drawing.Point(105, 19);
            this.cbMaHang.Name = "cbMaHang";
            this.cbMaHang.Size = new System.Drawing.Size(153, 28);
            this.cbMaHang.TabIndex = 12;
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbGiaBan.Location = new System.Drawing.Point(402, 57);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.Size = new System.Drawing.Size(153, 27);
            this.tbGiaBan.TabIndex = 10;
            // 
            // tbTuNgay
            // 
            this.tbTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbTuNgay.Location = new System.Drawing.Point(105, 59);
            this.tbTuNgay.Name = "tbTuNgay";
            this.tbTuNgay.Size = new System.Drawing.Size(153, 27);
            this.tbTuNgay.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(283, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đến ngày :";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Red;
            this.btnTimKiem.Location = new System.Drawing.Point(569, 58);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 29);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(283, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên mặt hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Từ ngày :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hàng :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin mặt hàng đã bán";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(612, 454);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInBao
            // 
            this.btnInBao.BackColor = System.Drawing.Color.White;
            this.btnInBao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInBao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInBao.ForeColor = System.Drawing.Color.Red;
            this.btnInBao.Location = new System.Drawing.Point(612, 311);
            this.btnInBao.Name = "btnInBao";
            this.btnInBao.Size = new System.Drawing.Size(78, 29);
            this.btnInBao.TabIndex = 4;
            this.btnInBao.Text = "In báo";
            this.btnInBao.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCus
            // 
            this.dataGridViewCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCus.Location = new System.Drawing.Point(12, 239);
            this.dataGridViewCus.MultiSelect = false;
            this.dataGridViewCus.Name = "dataGridViewCus";
            this.dataGridViewCus.RowHeadersWidth = 51;
            this.dataGridViewCus.RowTemplate.Height = 29;
            this.dataGridViewCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCus.Size = new System.Drawing.Size(594, 320);
            this.dataGridViewCus.TabIndex = 5;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(707, 570);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridViewCus);
            this.Controls.Add(this.btnInBao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormReport";
            this.Text = "BÁO CÁO BÁN HÀNG";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTuNgay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInBao;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewCus;
        private System.Windows.Forms.TextBox tbGiaBan;
        private System.Windows.Forms.ComboBox cbMaHang;
        private System.Windows.Forms.TextBox tbTenMH;
    }
}