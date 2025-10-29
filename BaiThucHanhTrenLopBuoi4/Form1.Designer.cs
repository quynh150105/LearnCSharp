namespace BaiThucHanhTrenLopBuoi4
{
    partial class Bai1Form
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
            this.labManv = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labManv
            // 
            this.labManv.AutoSize = true;
            this.labManv.Location = new System.Drawing.Point(143, 18);
            this.labManv.Name = "labManv";
            this.labManv.Size = new System.Drawing.Size(91, 16);
            this.labManv.TabIndex = 0;
            this.labManv.Text = "Ma Nhan Vien";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(143, 59);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(52, 16);
            this.labHoTen.TabIndex = 1;
            this.labHoTen.Text = "Ho Ten";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(143, 100);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(50, 16);
            this.labDiaChi.TabIndex = 2;
            this.labDiaChi.Text = "Dia Chi";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(308, 12);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(258, 22);
            this.txtManv.TabIndex = 3;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(308, 64);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(258, 22);
            this.txtHoten.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(308, 116);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(258, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(755, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(755, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(755, 122);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(755, 174);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(104, 23);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tim";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(755, 286);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.diachi});
            this.dataTable.Location = new System.Drawing.Point(46, 194);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(674, 218);
            this.dataTable.TabIndex = 11;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            // 
            // manv
            // 
            this.manv.HeaderText = "Ma Nhan Vien";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 165;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Ho Ten";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 165;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Dia Chi";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 165;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(755, 232);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Bai1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.labDiaChi);
            this.Controls.Add(this.labHoTen);
            this.Controls.Add(this.labManv);
            this.Name = "Bai1Form";
            this.Text = "Data Nhan Vien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai1Form_FormClosing);
            this.Load += new System.EventHandler(this.Bai1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labManv;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.Button btnLoad;
    }
}

