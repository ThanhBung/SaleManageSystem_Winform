
namespace WinForm_PurchaseManagement
{
    partial class FormSale
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
            this.tbNgayHD = new System.Windows.Forms.TextBox();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDatMua = new System.Windows.Forms.Button();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbMatHang = new System.Windows.Forms.ComboBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.btnTrai = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPhai = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(354, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐƠN ĐẶT HÀNG";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbNgayHD);
            this.panel1.Controls.Add(this.tbMaHD);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnDatMua);
            this.panel1.Controls.Add(this.tbDiaChi);
            this.panel1.Controls.Add(this.btnTaoMoi);
            this.panel1.Controls.Add(this.tbMaKH);
            this.panel1.Controls.Add(this.tbTenKH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 148);
            this.panel1.TabIndex = 1;
            // 
            // tbNgayHD
            // 
            this.tbNgayHD.Location = new System.Drawing.Point(651, 59);
            this.tbNgayHD.Name = "tbNgayHD";
            this.tbNgayHD.Size = new System.Drawing.Size(190, 27);
            this.tbNgayHD.TabIndex = 14;
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(651, 19);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(142, 27);
            this.tbMaHD.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(519, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày đặt hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(519, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã hóa đơn :";
            // 
            // btnDatMua
            // 
            this.btnDatMua.BackColor = System.Drawing.Color.White;
            this.btnDatMua.Enabled = false;
            this.btnDatMua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatMua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatMua.ForeColor = System.Drawing.Color.Red;
            this.btnDatMua.Location = new System.Drawing.Point(711, 104);
            this.btnDatMua.Name = "btnDatMua";
            this.btnDatMua.Size = new System.Drawing.Size(94, 29);
            this.btnDatMua.TabIndex = 1;
            this.btnDatMua.Text = "Đặt mua";
            this.btnDatMua.UseVisualStyleBackColor = false;
            this.btnDatMua.Click += new System.EventHandler(this.btnDatMua_Click);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbDiaChi.Location = new System.Drawing.Point(168, 101);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(271, 27);
            this.tbDiaChi.TabIndex = 10;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.White;
            this.btnTaoMoi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaoMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaoMoi.ForeColor = System.Drawing.Color.Red;
            this.btnTaoMoi.Location = new System.Drawing.Point(568, 104);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(94, 29);
            this.btnTaoMoi.TabIndex = 0;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // tbMaKH
            // 
            this.tbMaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbMaKH.Location = new System.Drawing.Point(168, 19);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(105, 27);
            this.tbMaKH.TabIndex = 8;
            this.tbMaKH.TextChanged += new System.EventHandler(this.tbMaKH_TextChanged);
            // 
            // tbTenKH
            // 
            this.tbTenKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbTenKH.Location = new System.Drawing.Point(168, 59);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(182, 27);
            this.tbTenKH.TabIndex = 7;
            this.tbTenKH.TextChanged += new System.EventHandler(this.tbTenKH_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên khách hàng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khách hàng :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbMatHang);
            this.panel2.Controls.Add(this.tbSoLuong);
            this.panel2.Controls.Add(this.tbGia);
            this.panel2.Controls.Add(this.btnTrai);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnPhai);
            this.panel2.Location = new System.Drawing.Point(13, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 282);
            this.panel2.TabIndex = 3;
            // 
            // cbMatHang
            // 
            this.cbMatHang.FormattingEnabled = true;
            this.cbMatHang.Location = new System.Drawing.Point(111, 50);
            this.cbMatHang.Name = "cbMatHang";
            this.cbMatHang.Size = new System.Drawing.Size(175, 28);
            this.cbMatHang.TabIndex = 21;
            this.cbMatHang.SelectedIndexChanged += new System.EventHandler(this.cbMatHang_SelectedIndexChanged);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(111, 160);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(125, 27);
            this.tbSoLuong.TabIndex = 20;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(111, 102);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(125, 27);
            this.tbGia.TabIndex = 19;
            // 
            // btnTrai
            // 
            this.btnTrai.BackColor = System.Drawing.Color.White;
            this.btnTrai.Enabled = false;
            this.btnTrai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrai.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrai.ForeColor = System.Drawing.Color.Red;
            this.btnTrai.Location = new System.Drawing.Point(340, 102);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(57, 44);
            this.btnTrai.TabIndex = 18;
            this.btnTrai.Text = "<<";
            this.btnTrai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrai.UseVisualStyleBackColor = false;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(12, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Số lượng :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Giá :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mặt hàng :";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(403, 53);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(465, 212);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(142, 235);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(400, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Danh sách hàng mua :";
            // 
            // btnPhai
            // 
            this.btnPhai.BackColor = System.Drawing.Color.White;
            this.btnPhai.Enabled = false;
            this.btnPhai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhai.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPhai.ForeColor = System.Drawing.Color.Red;
            this.btnPhai.Location = new System.Drawing.Point(339, 52);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(57, 44);
            this.btnPhai.TabIndex = 18;
            this.btnPhai.Text = ">>";
            this.btnPhai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhai.UseVisualStyleBackColor = false;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(27, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Thông tin mua hàng";
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(909, 525);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormSale";
            this.Text = "QUẢN LÝ BÁN HÀNG";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDatMua;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNgayHD;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.ComboBox cbMatHang;
        private System.Windows.Forms.Label label13;
    }
}