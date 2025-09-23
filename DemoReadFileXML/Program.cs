// See https://aka.ms/new-console-template for more informatio

using System.Xml;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Chương trình đọc file xml");

XmlDocument doc = new XmlDocument();
doc.Load("XMLFile1.xml");
XmlElement root = doc.DocumentElement;
XmlNodeList list = root.SelectNodes("cuonsach");
int i = 1;
foreach(XmlNode item in list)
{
    Console.WriteLine("------------------");
    Console.WriteLine("Phần tử thứ: " + i);
    Console.WriteLine("Ten sach: " + item.SelectSingleNode("tensach").InnerText);
    Console.WriteLine("So trang: " + item.SelectSingleNode("sotrang").InnerText);
    Console.WriteLine("Ho ten tac gia: " + item.SelectSingleNode("tacgia/hoten").InnerText);
    Console.WriteLine("Dien thoai tac gia: " + item.SelectSingleNode("tacgia/dienthoai").InnerText);
    Console.WriteLine("Gia tien: " + item.SelectSingleNode("giatien").InnerText);
    i++;
}
Console.ReadKey();

