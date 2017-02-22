using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace course_site.Models
{
    public class Course
    {
        public int courseNumber { get; set; }
        public int courseYear { get; set; }
        public string courseTitle { get; set; }
        public int courseName { get; set; }
        public List<Lesson> lessonList { get; }

        public Course(DirectoryInfo coursedir)
        {
            var nameList = coursedir.Name.Split('-');
            courseYear = Int32.Parse(nameList[0]);
            courseTitle = nameList[0];

            lessonList = new List<Lesson>();
            foreach (var lessonFile in coursedir.GetFiles())
            {
                var lesson = new Lesson(lessonFile);
                lessonList.Add(lesson);
            }

            //Need name of course
            //Location of course
            //List of lessons in course
        }
    }
}
