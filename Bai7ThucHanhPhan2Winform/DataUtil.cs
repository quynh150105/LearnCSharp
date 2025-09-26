using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai7ThucHanhPhan2Winform
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string fileName;

        public DataUtil()
        {
            fileName = "Course.xml";
            doc = new XmlDocument();
            if (!File.Exists(fileName))
            {
                XmlElement course = doc.CreateElement("course");
                doc.AppendChild(course);
                doc.Save(fileName);
            }
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void AddStudent(Student s)
        {
            XmlElement st = doc.CreateElement("student");
            st.SetAttribute("id", s.id);
            XmlElement name = doc.CreateElement("name");
            name.InnerText = s.name;
            XmlElement age = doc.CreateElement("age");
            age.InnerText = s.age;
            XmlElement city = doc.CreateElement("city");
            city.InnerText = s.city;

            st.AppendChild(name);
            st.AppendChild(age);
            st.AppendChild(city);
            root.AppendChild(st);
            doc.Save(fileName);
        }

        public bool UpdateStudent(Student s)
        {
            XmlNode stfind = root.SelectSingleNode("student[@id='" + s.id+"']");
            if (stfind != null)
            {
                XmlElement st = doc.CreateElement("student");
                st.SetAttribute("id", s.id);
                XmlElement name = doc.CreateElement("name");
                name.InnerText = s.name;
                XmlElement age = doc.CreateElement("age");
                age.InnerText = s.age;
                XmlElement city = doc.CreateElement("city");
                city.InnerText = s.city;

                st.AppendChild(name);
                st.AppendChild(age);
                st.AppendChild(city);
                root.ReplaceChild(st, stfind);
                doc.Save(fileName);
                return true;
            }
            return false;
        }

        public bool DeleteStudent(string id)
        {
            XmlNode stfind = root.SelectSingleNode("student[@id='" + id + "']");
            if (stfind != null)
            {
                root.RemoveChild(stfind);
                doc.Save(fileName);
                return true;
            }
            return false;

        }

        public Student findById(string id)
        {
            XmlNode stfind = root.SelectSingleNode("student[@id='" + id + "']");
            Student student = null;
            if (stfind != null) {

                student = new Student();
                student.id = stfind.Attributes[0].InnerText;
                student.name = stfind.SelectSingleNode("name").InnerText;
                student.age = stfind.SelectSingleNode("age").InnerText;
                student.city = stfind.SelectSingleNode("city").InnerText;
            }
            return student;


        }

        public List<Student> findByCity(string city)
        {
            XmlNodeList stfind = root.SelectNodes("student[city='"+city+"']");
            List<Student> li = new List<Student>();

           foreach(XmlNode node in stfind)
            {
                Student student = new Student();
                student.id = node.Attributes["id"].InnerText;
                student.name = node.SelectSingleNode("name").InnerText;
                student.age = node.SelectSingleNode("age").InnerText;
                student.city = node.SelectSingleNode("city").InnerText;
                li.Add(student);
            }
            return li;
        }



        public List<Student> getAllStudent()
        {
            XmlNodeList nodes = root.SelectNodes("student");
            List<Student> li = new List<Student>();
            foreach(XmlNode item in nodes)
            {
                Student s = new Student();
                s.id = item.Attributes[0].InnerText;
                s.name = item.SelectSingleNode("name").InnerText;
                s.age = item.SelectSingleNode("age").InnerText;
                s.city = item.SelectSingleNode("city").InnerText;
                li.Add(s);
            }
            return li;

        }



    }
}
