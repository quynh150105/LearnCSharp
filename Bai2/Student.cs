using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Student
    {
        private String name;
        private int age;

        public Student()
        {

        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public String toString()
        {
            return "name: " + this.name + " " + "age: " + this.age;
        }
    }
}
