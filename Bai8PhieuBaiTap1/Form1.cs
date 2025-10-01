using System.Linq.Expressions;

namespace Bai8PhieuBaiTap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();

        private void Form1_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.manv = txtMaNv.Text;
            nv.hoten = txtHoTen.Text;
            nv.tuoi = txtTuoi.Text;
            nv.luong = txtLuong.Text;
            nv.xa = txtXa.Text;
            nv.huyen = txtHuyen.Text;
            nv.thanhPho = txtTinh.Text;
            nv.dienThoai = txtDienThoai.Text;
            data.AddNhanVien(nv);
            displayData();
            ClearTextBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txtMaNv.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtHuyen.Clear();
            txtTinh.Clear();
            txtXa.Clear();
            txtTuoi.Clear();
            txtLuong.Clear();
        }

        private void displayData()
        {
            dataGridView1.DataSource = data.getAllNhanVien();
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("xac nhan xoa?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (d == DialogResult.Yes)
            {
                bool check = data.deleteNhanVien(txtMaNv.Text);
                if (!check) {
                    MessageBox.Show("Khong xoa duoc");
                }
                else
                {
                    MessageBox.Show("Xoa Thanh Cong");
                }
                displayData();
                ClearTextBox();
            }
        }
    }
}
