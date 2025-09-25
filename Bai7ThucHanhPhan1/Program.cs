using System.Net.Sockets;
using System.Xml;

class Program
{
    static void  Main(String[] args)
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root = doc.CreateElement("thuvien");
        XmlElement cuonsach = doc.CreateElement("cuonsach");
        XmlElement tensach = doc.CreateElement("tensach");
        XmlText ttensach = doc.CreateTextNode("lap trinh java");
        XmlElement sotrang = doc.CreateElement("sotrang");
        XmlText tsotrang = doc.CreateTextNode("500");
        XmlElement tacgia = doc.CreateElement("tacgiaa");
        XmlElement hoten = doc.CreateElement("hoten");
        XmlText thoten = doc.CreateTextNode("LeNhuQuynh");
        XmlElement dienthoai = doc.CreateElement("dienthoai");
        XmlText tdienthoai = doc.CreateTextNode("0123456789");
        XmlElement giatien = doc.CreateElement("giatien");
        XmlText tgiatien = doc.CreateTextNode("50000");
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
        doc.AppendChild(root);
        doc.Save("thuvien.xml");
    }
}
