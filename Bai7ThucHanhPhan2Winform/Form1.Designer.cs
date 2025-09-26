namespace Bai7ThucHanhPhan2Winform
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
            txtAge = new TextBox();
            txtCity = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnLoadFile = new Button();
            btnFindById = new Button();
            btnFindByCity = new Button();
            btnClose = new Button();
            Lable = new Label();
            lbtCounts = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(402, 47);
            label1.Name = "label1";
            label1.Size = new Size(288, 31);
            label1.TabIndex = 0;
            label1.Text = "COURSE MANAGERMENT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 132);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Student id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 191);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 250);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Age";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 309);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(359, 245);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(359, 302);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(359, 188);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.AccessibleName = "";
            txtId.Location = new Point(359, 131);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 23);
            txtId.TabIndex = 8;
            txtId.TextChanged += textBox4_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(532, 134);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(532, 189);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(532, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(532, 299);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(684, 134);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(94, 29);
            btnLoadFile.TabIndex = 9;
            btnLoadFile.Text = "&Load File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnFindById
            // 
            btnFindById.Location = new Point(684, 189);
            btnFindById.Name = "btnFindById";
            btnFindById.Size = new Size(94, 29);
            btnFindById.TabIndex = 10;
            btnFindById.Text = "F&indById";
            btnFindById.UseVisualStyleBackColor = true;
            btnFindById.Click += btnFindById_Click;
            // 
            // btnFindByCity
            // 
            btnFindByCity.Location = new Point(684, 244);
            btnFindByCity.Name = "btnFindByCity";
            btnFindByCity.Size = new Size(94, 29);
            btnFindByCity.TabIndex = 11;
            btnFindByCity.Text = "&Find By City";
            btnFindByCity.UseVisualStyleBackColor = true;
            btnFindByCity.Click += btnFindByCity_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(684, 299);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 12;
            btnClose.Text = "Clo&se";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Lable
            // 
            Lable.AutoSize = true;
            Lable.Location = new Point(387, 385);
            Lable.Name = "Lable";
            Lable.Size = new Size(142, 20);
            Lable.TabIndex = 13;
            Lable.Text = "Numbers of Student";
            Lable.Click += label6_Click;
            // 
            // lbtCounts
            // 
            lbtCounts.AutoSize = true;
            lbtCounts.Location = new Point(606, 385);
            lbtCounts.Name = "lbtCounts";
            lbtCounts.Size = new Size(17, 20);
            lbtCounts.TabIndex = 13;
            lbtCounts.Text = "0";
            lbtCounts.Click += lbtCounts_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(192, 462);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(598, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.Click += GetAllStudent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 743);
            Controls.Add(dataGridView1);
            Controls.Add(lbtCounts);
            Controls.Add(Lable);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnFindByCity);
            Controls.Add(btnDelete);
            Controls.Add(btnFindById);
            Controls.Add(btnLoadFile);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(txtCity);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Course";
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
        private TextBox txtAge;
        private TextBox txtCity;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnLoadFile;
        private Button btnFindById;
        private Button btnFindByCity;
        private Button btnClose;
        private Label Lable;
        private Label lbtCounts;
        private DataGridView dataGridView1;
    }
}
