using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public int id { get; set; }
        public String name { get; set; }

        public String address { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
}