using ScoolWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoolWebApplication.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowManagerName()
        {
            ViewBag.ManagerName = "matan";
            return View();
        }

        public ActionResult GetManagerName()
        {
            Manager myManager = new Manager();
            myManager.FirstName = "matan";
            myManager.LastName = "ysayas";
            myManager.Phone = "851164616";

            return View(myManager);
        }

        public ActionResult ShowAllManagerName()
        {
            string[] allManagerNames = new string[] { "matan", "xax", "lior", "macos", "ahjhsas", "tfgfgi" };
            ViewBag.allManagerNames = allManagerNames;
            return View();
        }

        public ActionResult GetAllManagerName()
        {
            return View();
        }
        public ActionResult randomNumArray()
        {
            Random random = new Random();
            int[] numArray = new int[10];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = random.Next(0, 10);
            }
            ViewBag.numArray = numArray;
            return View();
        }

        public ActionResult nameArray()
        {
            string[] namesArray = new string[] { "matan", "lior", "bob", "marcos", "yosi", "haim", "ron", "avi", "gprge", "dgdgdg" };
            ViewBag.nameArray = namesArray;
            return View();
        }



        public ActionResult nameArrayJson()
        {
            string[] namesArray = new string[] { "matan", "lior", "bob", "marcos", "yosi", "haim", "ron", "avi", "gprge", "dgdgdg" };
            return Json(namesArray, JsonRequestBehavior.AllowGet);
        }







    }

}
