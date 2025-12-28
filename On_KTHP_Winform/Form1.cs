using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
namespace On_KTHP_Winform
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            string link = "https://localhost:44367/api/Nhanvien";

            HttpWebRequest request = WebRequest.CreateHttp(link);

            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Nhanvien[]));

            Object data = js.ReadObject(response.GetResponseStream());

            Nhanvien[] arr = data as Nhanvien[];

            dataGridView1.DataSource = arr;

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtMaNv.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtTrinhdo.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtLuong.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?manv={0}&hoten={1}&trinhdo={2}&luong={3}", txtMaNv.Text, txtHoten.Text, txtTrinhdo.Text, txtLuong.Text);

            string link = "https://localhost:44367/api/Nhanvien/" + postString;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";
            
            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            Object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                loadData();
                MessageBox.Show("Them Thanh Cong");
            }
            else
            {
                MessageBox.Show("Them That Bai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?manv={0}&hoten={1}&trinhdo={2}&luong={3}", txtMaNv.Text, txtHoten.Text, txtTrinhdo.Text, txtLuong.Text);

            string link = "https://localhost:44367/api/Nhanvien/" + postString;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PATCH";

            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            Object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                loadData();
                MessageBox.Show("Sua Thanh Cong");
            }
            else
            {
                MessageBox.Show("Sua That Bai");

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?manv={0}", txtMaNv.Text);

            string link = "https://localhost:44367/api/Nhanvien/" + postString;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "DELETE";

            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            Object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                loadData();
                MessageBox.Show("Xoa Thanh Cong");
            }
            else
            {
                MessageBox.Show("Xoa That Bai");

            }
        }
    }
}
