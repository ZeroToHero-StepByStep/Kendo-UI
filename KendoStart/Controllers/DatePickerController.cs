using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
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


        public ActionResult Product_Read([DataSourceRequest] DataSourceRequest request)
        {
                _context.Configuration.ProxyCreationEnabled = false;
                IQueryable<Student> students = _context.Students;
                DataSourceResult result = students.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}