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

namespace On_KTHP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            string link = "http://localhost/hoctichhop/api/sanpham";

            HttpWebRequest request = WebRequest.CreateHttp(link);

            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));

            Object data = js.ReadObject(response.GetResponseStream());

            SanPham[] arr = data as SanPham[];

            dataSanPham.DataSource = arr;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string link = "http://localhost/hoctichhop/api/sanpham?ma=" + txtMaSP.Text;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "GET";

            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));

            Object data = js.ReadObject(response.GetResponseStream());

            SanPham[] sp = data as SanPham[];

            dataSanPham.DataSource = null;

            dataSanPham.DataSource = sp;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postlink = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}",txtMaSP.Text,txtTenSP.Text,txtDonGIa.Text,txtMaDM.Text);
            string link = "http://localhost/hoctichhop/api/sanpham" + postlink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";

            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            
            Object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if(kq)
            {
                MessageBox.Show("Thêm thành công");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }


        }

        private void dataSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtMaSP.Text = dataSanPham.Rows[index].Cells[0].Value.ToString();
            txtTenSP.Text = dataSanPham.Rows[index].Cells[1].Value.ToString();
            txtDonGIa.Text = dataSanPham.Rows[index].Cells[2].Value.ToString();
            txtMaDM.Text = dataSanPham.Rows[index].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
                 return;
            
            string deletelink = string.Format("?ma={0}",txtMaSP.Text);
            string link = "http://localhost/hocrestful/api/sanpham" + deletelink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "DELETE";

            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            Object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if(kq)
            {
                MessageBox.Show("Xóa thành công");
                loadData();
            }
            else
            {
                MessageBox.Show("Nguoi dung ko ton tai");
            }   

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string updatelink = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", txtMaSP.Text, txtTenSP.Text, txtDonGIa.Text, txtMaDM.Text);
            string link = "http://localhost/hocrestful/api/sanpham" + updatelink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PATCH";

            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            Object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if(kq)
            {
                MessageBox.Show("Cập nhật thành công");
                loadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
