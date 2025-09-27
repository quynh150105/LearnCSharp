using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai8PhieuBaiTap1
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string fileName;

        public DataUtil()
        {
            fileName = @"E:\Ki5\TichHop\Bai8PhieuBaiTap1\bin\Debug\net8.0-windows\congty.xml";
            doc = new XmlDocument();
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public List<NhanVien> getAllNhanVien()
        {
            XmlNodeList list = root.SelectNodes("./nhanvien");
            List<NhanVien> li = new List<NhanVien>();

            foreach(XmlNode item in list)
            {
                NhanVien nv = new NhanVien();
                nv.manv = item.Attributes["manv"].Value;
                nv.hoten = item.SelectSingleNode("hoten").InnerText;
                nv.tuoi = item.SelectSingleNode("tuoi").InnerText;
                nv.luong = item.SelectSingleNode("luong").InnerText;
                nv.xa = item.SelectSingleNode("diachi/xa").InnerText;
                nv.huyen = item.SelectSingleNode("diachi/huyen").InnerText;
                nv.thanhPho = item.SelectSingleNode("diachi/thanhpho").InnerText;
                nv.dienThoai = item.SelectSingleNode("dienthoai").InnerText;
                li.Add(nv);
            }
            return li;
        }

        public bool AddNhanVien(NhanVien nhanVien)
        {
            XmlElement nhanvien = doc.CreateElement("nhanvien");
            nhanvien.SetAttribute("manv",nhanVien.manv);

            XmlElement hoten = doc.CreateElement("hoten");
            hoten.InnerText = nhanVien.hoten;
            nhanvien.AppendChild(hoten);

            XmlElement tuoi = doc.CreateElement("tuoi");
            tuoi.InnerText = nhanVien.tuoi;
            nhanvien.AppendChild(tuoi);

            XmlElement luong = doc.CreateElement("luong");
            luong.InnerText = nhanVien.luong;
            nhanvien.AppendChild(luong);

            XmlElement diachi = doc.CreateElement("diachi");
            XmlElement xa = doc.CreateElement("xa");
            xa.InnerText = nhanVien.xa;
            XmlElement huyen = doc.CreateElement("huyen");
            huyen.InnerText = nhanVien.huyen;
            XmlElement thanhpho = doc.CreateElement("thanhpho");
            thanhpho.InnerText = nhanVien.thanhPho;
            diachi.AppendChild(xa);
            diachi.AppendChild(huyen);
            diachi.AppendChild(thanhpho);
            nhanvien.AppendChild(diachi);

            XmlElement dienthoai = doc.CreateElement("dienthoai");
            dienthoai.InnerText = nhanVien.dienThoai;
            nhanvien.AppendChild(dienthoai);

            root.AppendChild(nhanvien);
            doc.Save(fileName);
            return true;
        }
    }
}
