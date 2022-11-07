// Design a c# program for displaying student details from a list (age,name,Department)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment
{
    public class Student
    {
        public int age;
        public string name;
        public string department;

        public string getdata()
        {
            return this.age + " : " + this.name + " : " + this.department;
        }

    }
}