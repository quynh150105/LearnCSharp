using Bai7ThucHanhPhan1;
using System.Xml;

class Program
{
    static void  Main(String[] args)
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root = doc.CreateElement("thuvien");
        CuonSach s1 = new CuonSach("j01","cong nghe thong tin","lap trinh java","500","Le Nhu quynh","0123456789","50000");
        ThemSach(doc, root, s1);
        CuonSach s2 = new CuonSach("C01", "cong nghe thong tin", "lap trinh C++", "500", "Le Nhu quynh", "0123456789", "50000");
        ThemSach(doc, root, s2);
        doc.AppendChild(root);
        doc.Save("thuvien.xml");
    }

     static public void ThemSach(XmlDocument doc, XmlElement root, CuonSach s)
    {
        XmlElement cuonsach = doc.CreateElement("cuonsach");
        cuonsach.SetAttribute("masach", s.masach);
        cuonsach.SetAttribute("theloai", s.theloai);
        XmlElement tensach = doc.CreateElement("tensach");
        XmlText ttensach = doc.CreateTextNode(s.tensach);
        XmlElement sotrang = doc.CreateElement("sotrang");
        XmlText tsotrang = doc.CreateTextNode(s.sotrang);
        XmlElement tacgia = doc.CreateElement("tacgia");
        XmlElement hoten = doc.CreateElement("hoten");
        XmlText thoten = doc.CreateTextNode(s.hoten);
        XmlElement dienthoai = doc.CreateElement("dienthoai");
        XmlText tdienthoai = doc.CreateTextNode(s.dienthoai);
        XmlElement giatien = doc.CreateElement("giatien");
        XmlText tgiatien = doc.CreateTextNode(s.giatien);
        tensach.AppendChild(ttensach);
        sotrang.AppendChild(tsotrang);
        hoten.AppendChild(thoten);
        dienthoai.AppendChild(tdienthoai);
        giatien.AppendChild(tgiatien);
        root.AppendChild(cuonsach);
        cuonsach.AppendChild(tensach);
        cuonsach.AppendChild(sotrang);
        cuonsach.AppendChild(tacgia);
        cuonsach.AppendChild(giatien);
        tacgia.AppendChild(hoten);
        tacgia.AppendChild(dienthoai);
    }

}
