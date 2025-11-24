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

namespace LeNhuQuynh_2023600638_KTHP_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            string link = "https://localhost:44337/api/Nhanvien";

            HttpWebRequest request = WebRequest.CreateHttp(link);
            
            WebResponse respone = request.GetResponse();
            
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Nhanvien[]));

            Object data = js.ReadObject(respone.GetResponseStream());

            Nhanvien[] arr = data as Nhanvien[]; 

            dataNhanVien.DataSource = arr;
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaNV.Text = dataNhanVien.Rows[d].Cells[0].Value.ToString();
            txtHoTens.Text = dataNhanVien.Rows[d].Cells[1].Value.ToString();
            txtTrinhDo.Text = dataNhanVien.Rows[d].Cells[2].Value.ToString();
            txtLuong.Text = dataNhanVien.Rows[d].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&trinhdo={2}&luong={3}",txtMaNV.Text,txtHoTens.Text,txtTrinhDo.Text,txtLuong.Text);

            string link = "https://localhost:44337/api/Nhanvien/" + postString;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";

            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            Object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if(kq)
            {
                loadData();
                MessageBox.Show("Them Thanh Cong");
            }
            else
            {
                MessageBox.Show("Them That Bai");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string deleteString = string.Format("?ma={0}", manv);
            string link = "https://localhost:44337/api/Nhanvien" + deleteString;

            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                loadData();
                MessageBox.Show("Xoa Thanh Cong");

            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }



        }
    }
}
