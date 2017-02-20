using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using course_site.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace course_site.Controllers
{
    public class CourseController : Controller
    {

        private CourseModel courseModel;

        public CourseController()
        {
            courseModel = new CourseModel();
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(courseModel.CourseList);
        }
    }
}
