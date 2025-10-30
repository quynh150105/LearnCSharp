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
    public partial class Bai1Form : Form
    {
        public Bai1Form()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        string fileName = @"E:\Ki5\\TichHop\BaiThucHanhTrenLopBuoi4\Bai1.xml";
        int d;

        public void DisplayData()
        {
            doc.Load(fileName);
            XmlNodeList ds = doc.SelectNodes("ds/nhanvien");
            dataTable.Rows.Clear();
            dataTable.ColumnCount = 3;

            foreach(XmlNode nv in ds)
            {
                int rowIndex = dataTable.Rows.Add();
                XmlNode manv = nv.SelectSingleNode("@manv");
                dataTable.Rows[rowIndex].Cells[0].Value = manv.InnerText.ToString();

                XmlNode hoten = nv.SelectSingleNode("hoten");
                dataTable.Rows[rowIndex].Cells[1].Value = hoten.InnerText.ToString();

                XmlNode diachi = nv.SelectSingleNode("diachi");
                dataTable.Rows[rowIndex].Cells[2].Value = diachi.InnerText.ToString();

            }

        }

        private void Bai1Form_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNode nhanvien = doc.CreateElement("nhanvien");

            XmlAttribute manv = doc.CreateAttribute("manv");
            manv.InnerText = txtManv.Text;

            XmlNode hoten = doc.CreateElement("hoten");
            hoten.InnerText = txtHoten.Text;

            XmlNode diachi = doc.CreateElement("diachi");
            diachi.InnerText = txtDiaChi.Text;

            nhanvien.Attributes.Append(manv);
            nhanvien.AppendChild(hoten);
            nhanvien.AppendChild(diachi);

            root.AppendChild(nhanvien);
            doc.Save(fileName);

            DisplayData();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bai1Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNode nv_cu = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtManv.Text.ToString() + "']");

            XmlNode nv_moi = doc.CreateElement("nhanvien");

            XmlAttribute manv = doc.CreateAttribute("manv");
            manv.InnerText = txtManv.Text;

            XmlNode hoten = doc.CreateElement("hoten");
            hoten.InnerText = txtHoten.Text;

            XmlNode diachi = doc.CreateElement("diachi");
            diachi.InnerText = txtDiaChi.Text;

            nv_moi.Attributes.Append(manv);
            nv_moi.AppendChild(hoten);
            nv_moi.AppendChild(diachi);

            root.ReplaceChild(nv_moi, nv_cu);
            doc.Save(fileName);
            DisplayData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNode deleteNhanVien = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtManv.Text + "']");

            root.RemoveChild(deleteNhanVien);
            doc.Save(fileName);
            DisplayData();

        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txtManv.Text = dataTable.Rows[d].Cells[0].Value.ToString();
            txtHoten.Text = dataTable.Rows[d].Cells[1].Value.ToString();
            txtDiaChi.Text = dataTable.Rows[d].Cells[2].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNode findNhanVien = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtManv.Text + "']");

            XmlNode manv = findNhanVien.SelectSingleNode("@manv");
            XmlNode hoten = findNhanVien.SelectSingleNode("hoten");
            XmlNode diachi = findNhanVien.SelectSingleNode("diachi");

            dataTable.Rows.Clear();

            dataTable.Rows[0].Cells[0].Value = manv.InnerText.ToString();
            dataTable.Rows[0].Cells[1].Value = hoten.InnerText.ToString();
            dataTable.Rows[0].Cells[2].Value = diachi.InnerText.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
