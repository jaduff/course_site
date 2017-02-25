﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using course_site.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace course_site.Controllers
{
    [Route("")]
    //[Route("Course")]
    public class CourseController : Controller
    {

        private CourseList courseList;

        public CourseController()
        {
            courseList = new CourseList();
        }
        // GET: /<controller>/

        public IActionResult Index()
        {
            return View(courseList);
        }

        [HttpGet("{courseYear}/{lessonNumber}")]
        public IActionResult Lesson(int courseYear, int lessonNumber)
        {
             
            //get lessonlist from course - need to pass courseYear to get course.
            Lesson lesson = courseList.getCourse(courseYear).getLesson(lessonNumber);
            return View(lesson);
        }

        [HttpGet("{courseYear}")]
        public IActionResult Course(int courseYear)
        {
            Course course = courseList.getCourse(courseYear);
            return View(course);
        }
    }
}
