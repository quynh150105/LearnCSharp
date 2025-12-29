namespace On_KTHP_Client
{
    partial class Form1
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
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonGIa = new System.Windows.Forms.TextBox();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSanPham = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(328, 12);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(396, 22);
            this.txtMaSP.TabIndex = 0;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(328, 74);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(396, 22);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtDonGIa
            // 
            this.txtDonGIa.Location = new System.Drawing.Point(328, 136);
            this.txtDonGIa.Name = "txtDonGIa";
            this.txtDonGIa.Size = new System.Drawing.Size(396, 22);
            this.txtDonGIa.TabIndex = 2;
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(328, 233);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(396, 22);
            this.txtMaDM.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(982, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(982, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(982, 128);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(982, 180);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tim";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ma San Pham";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ten San Pham";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Don gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ma Danh muc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataSanPham
            // 
            this.dataSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.DonGia,
            this.MaDanhMuc,
            this.TenSanPham});
            this.dataSanPham.Location = new System.Drawing.Point(125, 323);
            this.dataSanPham.Name = "dataSanPham";
            this.dataSanPham.RowHeadersWidth = 51;
            this.dataSanPham.RowTemplate.Height = 24;
            this.dataSanPham.Size = new System.Drawing.Size(812, 219);
            this.dataSanPham.TabIndex = 12;
            this.dataSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSanPham_CellClick);
            this.dataSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Ma San Pham";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Don gia";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Ma Danh Muc";
            this.MaDanhMuc.MinimumWidth = 6;
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.Width = 125;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Ten San Pham";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Width = 125;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(982, 246);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 13;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 580);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dataSanPham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaDM);
            this.Controls.Add(this.txtDonGIa);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDonGIa;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.Button btnLoadData;
    }
}

