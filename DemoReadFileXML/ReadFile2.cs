using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoReadFileXML
{
    internal class ReadFile2
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("chuong trinh doc file.xml 2.0");

            XmlDocument doc = new XmlDocument();
            doc.Load("XMLFile1.xml");
            XmlElement root = doc.DocumentElement;
            PrintNode(root);
            Console.ReadKey();
        }
        static void PrintNode(XmlNode node)
        {
            Console.WriteLine("Type =[" + node.NodeType + "]");
            Console.WriteLine("Name =[" + node.Name + "]");
            Console.WriteLine("Value =[" + node.Value + "]");

            XmlNodeList children = node.ChildNodes;

            if(children.Count > 0)
            {
                Console.WriteLine("cac con cua node " + node.Name + " la: ");
                foreach(XmlNode item in children)
                {
                    PrintNode(item);
                }
                Console.WriteLine("ket thuc node " + node.Name);
            }
        }
    }
}
