using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai7PhieuBaiTap1
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string fileName;

        public DataUtil()
        {
            fileName = "nganhang.xml";
            doc = new XmlDocument();
            if (!File.Exists(fileName))
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);

                XmlElement nganhang = doc.CreateElement("nganhang");
                doc.AppendChild(nganhang);

                doc.Save(fileName);
            }
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public List<TaiKhoan> getAllTaiKhoan()
        {
            XmlNodeList list = root.SelectNodes("./taikhoan");
            List<TaiKhoan> li = new List<TaiKhoan>();

            foreach (XmlNode item in list)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.soTaiKhoan = item.SelectSingleNode("sotaikhoan").InnerText;
                tk.tenTaiKhoan = item.SelectSingleNode("tentaikhoan").InnerText;
                tk.soTien = item.SelectSingleNode("sotien").InnerText;
                tk.diaChi = item.SelectSingleNode("diachi").InnerText;
                tk.dienThoai = item.SelectSingleNode("dienthoai").InnerText;
                li.Add(tk);
            }
            return li;
        }

        public void addTaiKhoan(TaiKhoan tk)
        {
            XmlNode old = root.SelectSingleNode("taikhoan[sotaikhoan='{tk.soTaiKhoan}']");
            

            XmlElement taikhoan = doc.CreateElement("taikhoan");

            XmlElement sotaikhoan = doc.CreateElement("sotaikhoan");
            sotaikhoan.InnerText = tk.soTaiKhoan;
            taikhoan.AppendChild(sotaikhoan);

            XmlElement tentaikhoan = doc.CreateElement("tentaikhoan");
            tentaikhoan.InnerText = tk.tenTaiKhoan;
            taikhoan.AppendChild(tentaikhoan);

            XmlElement diachi = doc.CreateElement("diachi");
            diachi.InnerText = tk.diaChi;
            taikhoan.AppendChild(diachi);

            XmlElement dienthoai = doc.CreateElement("dienthoai");
            dienthoai.InnerText = tk.dienThoai;
            taikhoan.AppendChild(dienthoai);

            XmlElement sotien = doc.CreateElement("sotien");
            sotien.InnerText = tk.soTien;
            taikhoan.AppendChild(sotien);

            root.AppendChild(taikhoan);
            doc.Save(fileName);

            
        }
    }
}
