namespace Bai7PhieuBaiTap1
{
    partial class Bank
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
            txtSoTaiKhoan = new TextBox();
            txtTenTaiKhoan = new TextBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            txtSoTien = new TextBox();
            btnAddTaiKhoan = new Button();
            btnClear = new Button();
            btlLoadFile = new Button();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 82);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "so tai khoan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 130);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "ten tai khoan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 178);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "dia chi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 226);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "dienthoai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 274);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "so tien";
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Location = new Point(237, 82);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(311, 27);
            txtSoTaiKhoan.TabIndex = 5;
            txtSoTaiKhoan.TextChanged += txtSoTaiKhoan_TextChanged;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(237, 128);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(311, 27);
            txtTenTaiKhoan.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(237, 174);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(311, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(237, 220);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(311, 27);
            txtDienThoai.TabIndex = 8;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(237, 266);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(311, 27);
            txtSoTien.TabIndex = 9;
            // 
            // btnAddTaiKhoan
            // 
            btnAddTaiKhoan.Location = new Point(636, 117);
            btnAddTaiKhoan.Name = "btnAddTaiKhoan";
            btnAddTaiKhoan.Size = new Size(138, 38);
            btnAddTaiKhoan.TabIndex = 10;
            btnAddTaiKhoan.Text = "Them Tai Khoan";
            btnAddTaiKhoan.UseVisualStyleBackColor = true;
            btnAddTaiKhoan.Click += btnAddTaiKhoan_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(636, 219);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 38);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btlLoadFile
            // 
            btlLoadFile.Location = new Point(819, 117);
            btlLoadFile.Name = "btlLoadFile";
            btlLoadFile.Size = new Size(138, 38);
            btlLoadFile.TabIndex = 14;
            btlLoadFile.Text = "Load File";
            btlLoadFile.UseVisualStyleBackColor = true;
            btlLoadFile.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(117, 384);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(810, 218);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += ShowData;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(819, 220);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 36);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Bank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 659);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(btlLoadFile);
            Controls.Add(btnClear);
            Controls.Add(btnAddTaiKhoan);
            Controls.Add(txtSoTien);
            Controls.Add(txtDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(txtSoTaiKhoan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bank";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountManagement";
            Load += Bank_Load;
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
        private TextBox txtSoTaiKhoan;
        private TextBox txtTenTaiKhoan;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtSoTien;
        private Button btnAddTaiKhoan;
        private Button btnClear;
        private Button btlLoadFile;
        private DataGridView dataGridView1;
        private Button btnClose;
    }
}
