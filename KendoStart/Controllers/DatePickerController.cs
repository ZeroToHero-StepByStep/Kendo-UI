using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoStart.Models;

namespace KendoStart.Controllers
{
    public class DatePickerController : Controller
    {
        private IC_DataBase _context;

        public DatePickerController()
        {
             _context = new IC_DataBase(); 
        }
        // GET: DatePicker
        public ActionResult Index()
        {
            var students = _context.Students.ToList();
            ViewBag.students = students;
            return View();
        }
    }
}