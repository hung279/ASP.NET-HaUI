using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CourseStudent
    {
        public Course course { get; set; }
        public List<Student> students { get; set; }

        public CourseStudent()
        {
            course = new Course();
            students = new List<Student>();
        }

        public CourseStudent(Course course, List<Student> students)
        {
            this.course = course;
            this.students = students;
        }
    }
}