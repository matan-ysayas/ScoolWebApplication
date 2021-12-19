using ScoolWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoolWebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

                Student myStudent = new Student();

                myStudent.FirstName = "matan";
                myStudent.LastName = "ysayas";
                myStudent.YearOfBirth = 1996;
                myStudent.Grade = 8;

               

                return Json(myStudent,JsonRequestBehavior.AllowGet);
            

        }

        public ActionResult ShowStudentName()
        {
            
            return Json("matan",JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetStudentName()
        {
            Student student = CarteStudentObj();

            return Json(student,JsonRequestBehavior.AllowGet);
        }

        private static Student CarteStudentObj()
        {
            Student student = new Student();
            student.FirstName = "bob";
            student.LastName = "sds";
            student.YearOfBirth = 1996;
            student.Grade = 4;
            return student;
        }

        public ActionResult ShowAllStudentName()
        {
            string[] allStudentNames = new string[] { "matan", "bob", "lior", "macos", "avi", "tosi" };
            ViewBag.allStudentNames = allStudentNames;
            return Json(allStudentNames,JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAlltudentName()
        {
           return View();
        }

        public ActionResult ListOfStudent()
        {
            List<Student> studentList = StudentList();

            return Json(studentList,JsonRequestBehavior.AllowGet);
        }

        private static List<Student> StudentList()
        {
            List<Student> studentList = new List<Student>();
            Student student1 = new Student("asas", "asas", 258, 6);
            Student student2 = new Student("sders", "wewes", 500, 7);
            Student student3 = new Student("vvbt", "wtyui", 778, 10);
            Student student4 = new Student("opop", "ioio", 2448, 5);

            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            return studentList;
        }        
        
        
      
    }
}