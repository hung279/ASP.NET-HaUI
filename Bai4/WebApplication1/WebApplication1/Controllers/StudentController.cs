using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ViewAStudent()
        {
            Student student = new Student(1, "Hung", "Ha Noi"); 
            return View(student);
        }

        public ActionResult ViewStudents()
        {
            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student(1, "Hung", "HN"));
            studentsList.Add(new Student(2, "Huong", "HN"));
            studentsList.Add(new Student(3, "Linh", "HN"));

            return View(studentsList);
        }

        public ActionResult ViewCourse()
        {
            Course course = new Course(1, "Java");

            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student(1, "Hung", "HN"));
            studentsList.Add(new Student(2, "Huong", "HN"));
            studentsList.Add(new Student(3, "Linh", "HN"));

            CourseStudent cs = new CourseStudent(course, studentsList);

            return View(cs);
        }

        public ActionResult ViewThreeList()
        {
            List<Student> studentsList1 = new List<Student>();
            studentsList1.Add(new Student(1, "Hung", "HN"));
            studentsList1.Add(new Student(2, "Huong", "HN"));
            studentsList1.Add(new Student(3, "Linh", "HN"));

            List<Student> studentsList2 = new List<Student>();
            studentsList2.Add(new Student(4, "Hung1", "HN"));
            studentsList2.Add(new Student(5, "Huong1", "HN"));
            studentsList2.Add(new Student(6, "Linh1", "HN"));

            List<Student> studentsList3 = new List<Student>();
            studentsList3.Add(new Student(7, "Hung2", "HN"));
            studentsList3.Add(new Student(8, "Huong2", "HN"));
            studentsList3.Add(new Student(9, "Linh2", "HN"));

            ViewBag.list1 = studentsList1;
            ViewBag.list2 = studentsList2;
            ViewBag.list3 = studentsList3;

            return View();

        }
    }
}