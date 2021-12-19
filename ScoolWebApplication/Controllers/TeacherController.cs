using ScoolWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoolWebApplication.Controllers
{
    public class TeacherController : Controller
    {
        public object T { get; private set; }

        // GET: Teacher
        public ActionResult Index()
        {
            Teacher myTeacher = new Teacher();

            
            return View();
        }

        public ActionResult ShowTeacherName()
        {

            ViewBag.TeacherName = "bob";
            return View();
        }


        public ActionResult GetTeacherName()
        {
            Teacher myTeacer=new Teacher();
            myTeacer.FirstName = "ron";
            myTeacer.LastName = "avner";
            myTeacer.YearOfBirth = 1996;
            myTeacer.Payment = 500;
            return View(myTeacer);
        }

        public ActionResult ShowAllTeacherName()
        {
            string[] allTeachersNames = new string[] { "matan", "dfdf", "ldf", "ees", "aas", "sdsd" };
            ViewBag.allStudentNames = allTeachersNames;
            return View();
        }

        public ActionResult GetAllTeacherName()
        {
            return View();
        }

        public ActionResult TeacherJson()
        {
            string[] allTeachersNames = new string[] { "matan", "dfdf", "ldf", "ees", "aas", "sdsd" };
            return Json(allTeachersNames, JsonRequestBehavior.AllowGet);
        }


        public ActionResult TeacherList()
        {
            List<Teacher> teacherList = new List<Teacher>();
            Teacher teacher1 = new Teacher("asas", "asas", 258, 6);
            Teacher teacher2 = new Teacher("sders", "wewes", 500, 7);
            Teacher teacher3 = new Teacher("vvbt", "wtyui", 778, 10);
            Teacher teacher4 = new Teacher("opop", "ioio", 2448, 5);

            teacherList.Add(teacher1);
            teacherList.Add(teacher2);
            teacherList.Add(teacher3);
            teacherList.Add(teacher4);

            return View(teacherList);

        }

    }
}