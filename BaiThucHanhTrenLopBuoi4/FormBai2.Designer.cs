namespace BaiThucHanhTrenLopBuoi4
{
    partial class FormBai2
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtTrinhdo = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.gtNam = new System.Windows.Forms.RadioButton();
            this.gtNu = new System.Windows.Forms.RadioButton();
            this.dataNhanVien = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(764, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(764, 57);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 29);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(764, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(764, 147);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(99, 29);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tim";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(764, 192);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 29);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ma Nhan Vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "HoTen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gioi Tinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trinh Do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dia Chi";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(395, 19);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(254, 22);
            this.txtManv.TabIndex = 10;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(395, 64);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(254, 22);
            this.txtHoten.TabIndex = 11;
            // 
            // txtTrinhdo
            // 
            this.txtTrinhdo.Location = new System.Drawing.Point(395, 160);
            this.txtTrinhdo.Name = "txtTrinhdo";
            this.txtTrinhdo.Size = new System.Drawing.Size(254, 22);
            this.txtTrinhdo.TabIndex = 12;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(395, 202);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(254, 22);
            this.txtDiachi.TabIndex = 13;
            // 
            // gtNam
            // 
            this.gtNam.AutoSize = true;
            this.gtNam.Location = new System.Drawing.Point(395, 111);
            this.gtNam.Name = "gtNam";
            this.gtNam.Size = new System.Drawing.Size(57, 20);
            this.gtNam.TabIndex = 14;
            this.gtNam.TabStop = true;
            this.gtNam.Text = "Nam";
            this.gtNam.UseVisualStyleBackColor = true;
            // 
            // gtNu
            // 
            this.gtNu.AutoSize = true;
            this.gtNu.Location = new System.Drawing.Point(546, 111);
            this.gtNu.Name = "gtNu";
            this.gtNu.Size = new System.Drawing.Size(45, 20);
            this.gtNu.TabIndex = 15;
            this.gtNu.TabStop = true;
            this.gtNu.Text = "Nu";
            this.gtNu.UseVisualStyleBackColor = true;
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.gioitinh,
            this.trinhdo,
            this.diachi});
            this.dataNhanVien.Location = new System.Drawing.Point(75, 254);
            this.dataNhanVien.Name = "dataNhanVien";
            this.dataNhanVien.RowHeadersWidth = 51;
            this.dataNhanVien.RowTemplate.Height = 24;
            this.dataNhanVien.Size = new System.Drawing.Size(899, 181);
            this.dataNhanVien.TabIndex = 16;
            this.dataNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellClick);
            // 
            // manv
            // 
            this.manv.HeaderText = "Ma Nhan Vien";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 125;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Ho Ten";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Gioi Tinh";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // trinhdo
            // 
            this.trinhdo.HeaderText = "Trinh Do";
            this.trinhdo.MinimumWidth = 6;
            this.trinhdo.Name = "trinhdo";
            this.trinhdo.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Dia Chi";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // FormBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 464);
            this.Controls.Add(this.dataNhanVien);
            this.Controls.Add(this.gtNu);
            this.Controls.Add(this.gtNam);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTrinhdo);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "FormBai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Nhan Vien";
            this.Load += new System.EventHandler(this.FormBai2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtTrinhdo;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.RadioButton gtNam;
        private System.Windows.Forms.RadioButton gtNu;
        private System.Windows.Forms.DataGridView dataNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}