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
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        string fileName = "E:\\Ki5\\TichHop\\BaiThucHanhTrenLopBuoi4\\Bai2.xml";

        public void Display()
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNodeList ds = root.SelectNodes("/ds/nhanvien");

           

            foreach(XmlNode nv in ds)
            {
                XmlNode manv = nv.SelectSingleNode("@manv");
                XmlNode hoten = nv.SelectSingleNode("hoten");
                XmlNode gioitinh = nv.SelectSingleNode("gioitinh");
                XmlNode trinhdo = nv.SelectSingleNode("trinhdo");
                XmlNode diachi = nv.SelectSingleNode("diachi");

                int d = dataNhanVien.Rows.Add();

                dataNhanVien.Rows[d].Cells[0].Value = manv.InnerText;
                dataNhanVien.Rows[d].Cells[1].Value = hoten.InnerText;
                dataNhanVien.Rows[d].Cells[2].Value = gioitinh.InnerText;
                dataNhanVien.Rows[d].Cells[3].Value = trinhdo.InnerText;
                dataNhanVien.Rows[d].Cells[4].Value = diachi.InnerText;


            }
            

        }

        private void FormBai2_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataNhanVien.Rows.Clear();
            Display();
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

            XmlNode gioitinh = doc.CreateElement("gioitinh");
            if (gtNam.Checked)
            {
                gioitinh.InnerText = gtNam.Text;
            }
            if(gtNu.Checked)
            {
                gioitinh.InnerText=gtNu.Text;
            }
            

            XmlNode trinhdo = doc.CreateElement("trinhdo");
            trinhdo.InnerText = txtTrinhdo.Text;

            XmlNode diachi = doc.CreateElement("diachi");
            diachi.InnerText = txtDiachi.Text;

            nhanvien.Attributes.Append(manv);
            nhanvien.AppendChild(hoten);
            nhanvien.AppendChild(gioitinh);
            nhanvien.AppendChild(trinhdo);
            nhanvien.AppendChild(diachi);

            root.AppendChild(nhanvien);
            doc.Save(fileName);

            dataNhanVien.Rows.Clear();
            Display();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNode changeNhanvien = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtManv.Text + "']");

            XmlNode hoten = changeNhanvien.SelectSingleNode("hoten");
            hoten.InnerText = txtHoten.Text;

            XmlNode gioitinh = changeNhanvien.SelectSingleNode("gioitinh");
            if (gtNam.Checked)
            {
                gioitinh.InnerText = gtNam.Text;
            }
            if (gtNu.Checked)
            {
                gioitinh.InnerText = gtNu.Text;
            }

            XmlNode trinhdo = changeNhanvien.SelectSingleNode("trinhdo");
            trinhdo.InnerText = txtTrinhdo.Text;

            XmlNode diachi = changeNhanvien.SelectSingleNode("trinhdo");
            diachi.InnerText = txtDiachi.Text;

            doc.Save(fileName);
            dataNhanVien.Rows.Clear();
            Display();


        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtManv.Text = dataNhanVien.Rows[d].Cells[0].Value.ToString();
            txtHoten.Text = dataNhanVien.Rows[d].Cells[1].Value.ToString();
            if (gtNam.Text == dataNhanVien.Rows[d].Cells[2].Value.ToString())
            {
                gtNam.Checked = true;
            }
            else
            {
                gtNu.Checked = true;
            }
            txtTrinhdo.Text = dataNhanVien.Rows[d].Cells[3].Value.ToString();
            txtDiachi.Text = dataNhanVien.Rows[d].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);

            XmlElement root = doc.DocumentElement;

            XmlNode deleteNhanVien = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtManv.Text + "']");

            root.RemoveChild(deleteNhanVien);

            doc.Save(fileName);
            dataNhanVien.Rows.Clear();
            Display();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            XmlElement root = doc.DocumentElement;

            XmlNode findNhanVien = root.SelectSingleNode("/ds/nhanvien[@manv='" + txtManv.Text + "']");

            XmlNode manv = findNhanVien.SelectSingleNode("@manv");
            XmlNode hoten = findNhanVien.SelectSingleNode("hoten");
            XmlNode gioitinh = findNhanVien.SelectSingleNode("gioitinh");
            XmlNode trinhdo = findNhanVien.SelectSingleNode("trinhdo");
            XmlNode diachi = findNhanVien.SelectSingleNode("diachi");

            dataNhanVien.Rows.Clear();

            dataNhanVien.Rows[0].Cells[0].Value = manv.InnerText;
            dataNhanVien.Rows[0].Cells[1].Value = hoten.InnerText;
            dataNhanVien.Rows[0].Cells[2].Value = gioitinh.InnerText;
            dataNhanVien.Rows[0].Cells[3].Value = trinhdo.InnerText;
            dataNhanVien.Rows[0].Cells[4].Value = diachi.InnerText;



        }
    }
}
