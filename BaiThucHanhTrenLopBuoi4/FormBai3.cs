using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BaiThucHanhTrenLopBuoi4
{
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
        }
        
        XmlDocument doc = new XmlDocument();
        string fileName = @"E:\Ki5\\TichHop\BaiThucHanhTrenLopBuoi4\Bai3.xml";

        public void DisplayData()
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            dataNhanVien.Rows.Clear();

            XmlNodeList ds = root.SelectNodes("/ds/nhanvien");

            foreach(XmlNode nv in ds)
            {
                XmlNode manv = nv.SelectSingleNode("@manv");
                XmlNode ho = nv.SelectSingleNode("hoten/ho");
                XmlNode ten = nv.SelectSingleNode("hoten/ten");
                XmlNode diachi = nv.SelectSingleNode("diachi");

                int index = dataNhanVien.Rows.Add();

                dataNhanVien.Rows[index].Cells[0].Value = manv.InnerText;
                dataNhanVien.Rows[index].Cells[1].Value = ho.InnerText;
                dataNhanVien.Rows[index].Cells[2].Value = ten.InnerText;
                dataNhanVien.Rows[index].Cells[3].Value = diachi.InnerText;

            }
        }

        private void FormBai3_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            
            txtMaNV.Text = dataNhanVien.Rows[d].Cells[0].Value.ToString();
            txtHo.Text = dataNhanVien.Rows[d].Cells[1].Value.ToString();
            txtTen.Text = dataNhanVien.Rows[d].Cells[2].Value.ToString();
            txtDiaChi.Text = dataNhanVien.Rows[d].Cells[3].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNode NhanVien = doc.CreateElement("nhanvien");

            XmlAttribute MaNhanVien = doc.CreateAttribute("manv");
            MaNhanVien.InnerText = txtMaNV.Text;

            XmlNode Hoten = doc.CreateElement("hoten");
            XmlNode ho = doc.CreateElement("ho");
            ho.InnerText = txtHo.Text;
            XmlNode ten = doc.CreateElement("ten");
            ten.InnerText = txtTen.Text;
            Hoten.AppendChild(ho);
            Hoten.AppendChild(ten);

            XmlNode Diachi = doc.CreateElement("diachi");
            Diachi.InnerText = txtDiaChi.Text;

            NhanVien.Attributes.Append(MaNhanVien);
            NhanVien.AppendChild(Hoten);
            NhanVien.AppendChild(Diachi);

            root.AppendChild(NhanVien);

            doc.Save(fileName);

            DisplayData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNode changeNhanVien = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtMaNV.Text + "']");

            XmlNode ho = changeNhanVien.SelectSingleNode("hoten/ho");
            ho.InnerText = txtHo.Text;

            XmlNode ten = changeNhanVien.SelectSingleNode("hoten/ten");
            ten.InnerText = txtTen.Text;

            XmlNode diachi = changeNhanVien.SelectSingleNode("diachi");
            diachi.InnerText = txtDiaChi.Text;

            doc.Save(fileName);
            DisplayData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNode deleteNhanVien = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtMaNV.Text + "']");

            root.RemoveChild(deleteNhanVien);

            doc.Save(fileName);
            DisplayData();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;
            XmlNode findNhanVien = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtMaNV.Text + "']");

            XmlNode manv = findNhanVien.SelectSingleNode("@manv");
            XmlNode ho = findNhanVien.SelectSingleNode("hoten/ho");
            XmlNode ten = findNhanVien.SelectSingleNode("hoten/ten");
            XmlNode diachi = findNhanVien.SelectSingleNode("diachi");

            dataNhanVien.Rows.Clear();

            dataNhanVien.Rows[0].Cells[0].Value = manv.InnerText;
            dataNhanVien.Rows[0].Cells[1].Value = ho.InnerText;
            dataNhanVien.Rows[0].Cells[2].Value = ten.InnerText;
            dataNhanVien.Rows[0].Cells[3].Value = diachi.InnerText;
        }
    }
}
