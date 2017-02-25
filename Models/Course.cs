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
        //public int courseName { get; set; }
        public SortedDictionary<int, Lesson> lessonDict { get; }

        public Course(DirectoryInfo coursedir)
        {
            var nameList = coursedir.Name.Split('-', '_', ' ');
            courseYear = Int32.Parse(nameList[0]);

            courseTitle = "Year " + courseYear + " - ";

            if (nameList.Length > 1)
            {
                foreach (String _word in nameList.Skip(1)){
                    courseTitle = courseTitle + _word.First().ToString().ToUpper() + _word.Substring(1);
                }
            } else
            {
                courseTitle = courseTitle + "Digital Technologies";
            }



            lessonDict = new SortedDictionary<int, Lesson>();
            foreach (var lessonFile in coursedir.GetFiles())
            {
                var lesson = new Lesson(lessonFile);
                lesson.courseYear = courseYear;
                lessonDict.Add(lesson.lessonNumber,lesson);
            }

            //Need name of course
            //Location of course
            //List of lessons in course
        }

        public Lesson getLesson(int lessonNumber)
        {

            return lessonDict[lessonNumber];
        }
    }
}
