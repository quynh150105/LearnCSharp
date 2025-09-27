namespace Bai8PhieuBaiTap1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtMaNv = new TextBox();
            txtHoTen = new TextBox();
            txtTuoi = new TextBox();
            txtLuong = new TextBox();
            txtXa = new TextBox();
            txtHuyen = new TextBox();
            txtTinh = new TextBox();
            txtDienThoai = new TextBox();
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            btnClear = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 41);
            label1.TabIndex = 0;
            label1.Text = "Quan Ly Nhan Vien";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 109);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Ma Nhan Vien";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 156);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Ho Ten";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 203);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Tuoi ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 250);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Luong";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(193, 297);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 5;
            label6.Text = "Xa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(193, 344);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 6;
            label7.Text = "Huyen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(193, 391);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 7;
            label8.Text = "Tinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(193, 438);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 8;
            label9.Text = "Dien Thoai";
            // 
            // txtMaNv
            // 
            txtMaNv.Location = new Point(363, 109);
            txtMaNv.Name = "txtMaNv";
            txtMaNv.Size = new Size(354, 27);
            txtMaNv.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(363, 156);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(354, 27);
            txtHoTen.TabIndex = 10;
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(363, 203);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(354, 27);
            txtTuoi.TabIndex = 11;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(363, 250);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(354, 27);
            txtLuong.TabIndex = 12;
            txtLuong.TextChanged += textBox4_TextChanged;
            // 
            // txtXa
            // 
            txtXa.Location = new Point(363, 297);
            txtXa.Name = "txtXa";
            txtXa.Size = new Size(354, 27);
            txtXa.TabIndex = 13;
            // 
            // txtHuyen
            // 
            txtHuyen.Location = new Point(363, 344);
            txtHuyen.Name = "txtHuyen";
            txtHuyen.Size = new Size(354, 27);
            txtHuyen.TabIndex = 14;
            // 
            // txtTinh
            // 
            txtTinh.Location = new Point(363, 391);
            txtTinh.Name = "txtTinh";
            txtTinh.Size = new Size(354, 27);
            txtTinh.TabIndex = 15;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(363, 438);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(354, 27);
            txtDienThoai.TabIndex = 16;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(820, 105);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load File";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(108, 490);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(876, 241);
            dataGridView1.TabIndex = 18;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(820, 335);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(820, 169);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(820, 249);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 21;
            btnThem.Text = "Add";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 743);
            Controls.Add(btnThem);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoad);
            Controls.Add(txtDienThoai);
            Controls.Add(txtTinh);
            Controls.Add(txtHuyen);
            Controls.Add(txtXa);
            Controls.Add(txtLuong);
            Controls.Add(txtTuoi);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaNv);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Bai 8";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtMaNv;
        private TextBox txtHoTen;
        private TextBox txtTuoi;
        private TextBox txtLuong;
        private TextBox txtXa;
        private TextBox txtHuyen;
        private TextBox txtTinh;
        private TextBox txtDienThoai;
        private Button btnLoad;
        private DataGridView dataGridView1;
        private Button btnClose;
        private Button btnClear;
        private Button btnThem;
    }
}
