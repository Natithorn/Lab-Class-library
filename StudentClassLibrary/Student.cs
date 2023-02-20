using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassLibrary
{
    public class Student
    {
        private string name;
        private string Student_id;
        private int age;


        public Student(string name,string Student_id)
        {
            this.name = name;
            this.Student_id = Student_id;
        }
        public string displayInfo()
        {
            return Student_id + "," + name + "\r\n";
        }
       
    }
}
