using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoStart.Models;

namespace KendoStart.Controllers
{
    public class StudentController : Controller
    {
        private IC_DataBase _context ;

        public StudentController()
        {
         
            _context = new IC_DataBase();
            _context.Configuration.ProxyCreationEnabled = false;
        }


        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Student_read()
        {
            var students = _context.Students;
            return Json(students , JsonRequestBehavior.AllowGet);
        }
    }
}