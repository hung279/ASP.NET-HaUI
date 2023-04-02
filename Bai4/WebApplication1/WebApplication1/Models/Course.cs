using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Course
    {
        public int id { get; set; }
        public String name { get; set; }

        public Course()
        {

        }

        public Course(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}