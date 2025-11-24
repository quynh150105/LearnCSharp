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

namespace BaiThucHanhTrenLopBuoi6Phan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            string link = "https://localhost:44347/api/sanpham";

            HttpWebRequest request = WebRequest.CreateHttp(link);

            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));

            Object data = js.ReadObject(response.GetResponseStream());

            SanPham[] arr = data as SanPham[];

            dataSanPham.DataSource = arr;
        }

        public void loadDanhMuc()
        {
            string link = "https://localhost:44347/api/danhmuc";

            HttpWebRequest request = WebRequest.CreateHttp(link);

            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));

            Object data = js.ReadObject(response.GetResponseStream());

            DanhMuc[] arr = data as DanhMuc[];

            comboDanhMux.DataSource = arr;
            comboDanhMux.ValueMember = "MaDanhMuc";
            comboDanhMux.DisplayMember = "TenDanhMuc";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            loadDanhMuc();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postLink = string.Format("?ma={0}&ten={1}&dongia={2}&madanhmuc={3}", txtMaSanPham.Text, txtTenSanPham.Text, txtDonGia.Text, comboDanhMux.SelectedValue);
            string link = "https://localhost:44347/api/sanpham/" + postLink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";

            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            Object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                LoadData();
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them That bai");
            }
        }

        private void dataSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaSanPham.Text = dataSanPham.Rows[d].Cells[0].Value.ToString();
            txtTenSanPham.Text = dataSanPham.Rows[d].Cells[1].Value.ToString();
            txtDonGia.Text = dataSanPham.Rows[d].Cells[2].Value.ToString();
            comboDanhMux.Text = dataSanPham.Rows[d].Cells[3].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string findMaDanhMuc = txtMaDanhMuc.Text;

            string link = "https://localhost:44347/api/sanpham?madanhmuc=" + findMaDanhMuc;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            // request.Method = "GET";

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham));

            Object data = js.ReadObject(request.GetResponse().GetResponseStream());

            SanPham[] arr = data as SanPham[];

            dataSanPham.DataSource = arr;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string putLink = string.Format("?ma={0}&ten={1}&dongia={2}&madanhmuc={3}", txtMaSanPham.Text, txtTenSanPham.Text, txtDonGia.Text, comboDanhMux.SelectedValue);
            string link = "https://localhost:44347/api/sanpham/" + putLink;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PUT";

            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            Object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                LoadData();
                MessageBox.Show("Sua thanh cong");
            }
            else
            {
                MessageBox.Show("Sua That bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masp = txtMaSanPham.Text;
            string deleteString = string.Format("?maSanPham={0}", masp);
            string link = "https://localhost:44347/api/sanpham" + deleteString;

            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq) {
                MessageBox.Show("Xoa Thanh cong");
                LoadData();
            }
            else
                MessageBox.Show("Xoa that bai"); 
        
        }
    }
}
