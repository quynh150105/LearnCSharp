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

namespace OnTapTx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string file = "E:\\Ki5\\TichHop\\OnTapTx2\\NhanVien.xml";
        XmlDocument doc = new XmlDocument();

        public void loadFile()
        {
            doc.Load(file);
            XmlElement root = doc.DocumentElement;
            dataNhanVien.Rows.Clear();

            XmlNodeList ds = root.SelectNodes("/ds/nhanvien");

            foreach(XmlNode nv in ds)
            {
                XmlNode manv = nv.SelectSingleNode("@manv");
                XmlNode ho = nv.SelectSingleNode("hoten/ho");
                XmlNode ten = nv.SelectSingleNode("hoten/ten");
                XmlNode gioitinh = nv.SelectSingleNode("gioitinh");
                XmlNode diachi = nv.SelectSingleNode("diachi");
                int index = dataNhanVien.Rows.Add();
                dataNhanVien.Rows[index].Cells[0].Value = manv.InnerText.ToString();
                dataNhanVien.Rows[index].Cells[1].Value = ho.InnerText.ToString();
                dataNhanVien.Rows[index].Cells[2].Value = ten.InnerText.ToString();
                dataNhanVien.Rows[index].Cells[4].Value = gioitinh.InnerText.ToString();
                dataNhanVien.Rows[index].Cells[3].Value = diachi.InnerText.ToString();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadFile();
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtManv.Text = dataNhanVien.Rows[index].Cells[0].Value.ToString();
            txtHo.Text = dataNhanVien.Rows[index].Cells[1].Value.ToString();
            txtTen.Text = dataNhanVien.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dataNhanVien.Rows[index].Cells[3].Value.ToString();
            txtGioiTinh.Text = dataNhanVien.Rows[index].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement root = doc.DocumentElement;

            XmlNode nhanvien = doc.CreateElement("nhanvien");

            XmlAttribute manv = doc.CreateAttribute("manv");
            manv.InnerText = txtManv.Text;

            XmlNode hoten = doc.CreateElement("hoten");
            XmlNode ho = doc.CreateElement("ho");
            ho.InnerText = txtHo.Text;
            XmlNode ten = doc.CreateElement("ten");
            ten.InnerText = txtTen.Text;
            hoten.AppendChild(ho);
            hoten.AppendChild(ten);

            XmlNode diachi = doc.CreateElement("diachi");
            diachi.InnerText = txtDiaChi.Text;

            XmlNode gioitinh = doc.CreateElement("gioitinh");
            gioitinh.InnerText = txtGioiTinh.Text;

            nhanvien.Attributes.Append(manv);
            nhanvien.AppendChild(hoten);
            nhanvien.AppendChild(diachi);
            nhanvien.AppendChild(gioitinh);

            root.AppendChild(nhanvien);
            doc.Save(file);
            loadFile();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement root = doc.DocumentElement;

            XmlNode changeNode = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtManv.Text + "']");

            XmlNode ho = changeNode.SelectSingleNode("hoten/ho");
            ho.InnerText = txtHo.Text;
            XmlNode ten = changeNode.SelectSingleNode("hoten/ten");
            ten.InnerText = txtTen.Text;

            XmlNode diachi = changeNode.SelectSingleNode("diachi");
            diachi.InnerText = txtDiaChi.Text;

            XmlNode gioitinh = changeNode.SelectSingleNode("gioitinh");
            gioitinh.InnerText = txtGioiTinh.Text;

            doc.Save(file);
            loadFile();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            XmlElement root = doc.DocumentElement;

            XmlNode deleteNode = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtManv.Text + "']");


            root.RemoveChild(deleteNode);
            doc.Save(file);
            loadFile();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadFile();
        }
    }
}
