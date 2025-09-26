namespace Bai7ThucHanhPhan2Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataUtil data = new DataUtil();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            dataGridView1.DataSource = data.getAllStudent();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 200;
            lbtCounts.Text = dataGridView1.Rows.Count + "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.id = txtId.Text;
            st.name = txtName.Text;
            st.age = txtAge.Text;
            st.city = txtCity.Text;
            data.AddStudent(st);
            ClearTextBox();
            displayData();
        }

        private void ClearTextBox()
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCity.Clear();
            ActiveControl = txtId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbtCounts_Click(object sender, EventArgs e)
        {

        }

        private void GetAllStudent(object sender, EventArgs e)
        {
            Student st = (Student)dataGridView1.CurrentRow.DataBoundItem;
            txtId.Text = st.id;
            txtName.Text = st.name;
            txtAge.Text = st.age;
            txtCity.Text = st.city;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.id = txtId.Text;
            st.name = txtName.Text;
            st.age = txtAge.Text;
            st.city = txtCity.Text;
            bool check = data.UpdateStudent(st);
            if (!check)
            {
                MessageBox.Show("Khong cap nhat duoc sinh vien!");
                return;
            }
            displayData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xac nhan xoa?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (d == DialogResult.Yes)
            {
                bool check = data.DeleteStudent(txtId.Text);
                if (!check)
                {
                    MessageBox.Show("Khong xoa duoc");
                    return;
                }
                displayData();
                ClearTextBox();

            }


        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            List<Student> students = new List<Student>();
            Student s = data.findById(id);
            if (s != null)
            {
                students.Add(s);
                dataGridView1.DataSource = students;
                lbtCounts.Text = dataGridView1.Rows.Count + "";
                txtId.Text = s.id;
                txtName.Text = s.name;
                txtAge.Text = s.age;
                txtCity.Text = s.city;
                return;
            }
            MessageBox.Show("Khong tim thay sinh vien");
        }

        private void btnFindByCity_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            List<Student> li = data.findByCity(city);

            if (li.Count > 0)
            {
                dataGridView1.DataSource = li;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 250;
                dataGridView1.Columns[2].Width = 50;
                dataGridView1.Columns[3].Width = 200;
                lbtCounts.Text = dataGridView1.Rows.Count + "";
                return;
            }




            MessageBox.Show("Khong tim thay sinh vien");
        }
    }
}
