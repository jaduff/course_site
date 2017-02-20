using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using course_site.Models;

namespace course_site.ViewModels
{
    public class CourseViewModel
    {
        public CourseModel courseModel { get;}

        public CourseViewModel()
        {
            courseModel = new CourseModel();
        }
    }
}
