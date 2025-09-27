namespace Bai7PhieuBaiTap1
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        DataUtil data = new DataUtil();

        public void displayData()
        {
            dataGridView1.DataSource = data.getAllTaiKhoan();
            dataGridView1.Columns[0].Width = 170;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;

        }

        private void txtSoTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void Bank_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSoTaiKhoan.Clear();
            txtTenTaiKhoan.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtSoTien.Clear();
            ActiveControl = txtSoTaiKhoan;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.soTaiKhoan = txtSoTaiKhoan.Text;
            tk.tenTaiKhoan = txtTenTaiKhoan.Text;
            tk.diaChi = txtDiaChi.Text;
            tk.dienThoai = txtDienThoai.Text;
            tk.soTien = txtSoTien.Text;
            data.addTaiKhoan(tk);
            displayData();
        }

        private void ShowData(object sender, DataGridViewCellEventArgs e)
        {
            displayData();
        }
    }
}
