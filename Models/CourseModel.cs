using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace course_site.Models
{
    public class CourseModel
    {
        // Need to read list of directories in a location
        // Return list of courses based on directory names
        // Need to read list of html files in a given directory
        // Return list of lessons based on file names
        // Need to read HTML into View from a given lesson

        public List<Course> CourseList { get; }

        public CourseModel()
        {
            CourseList = new List<Course>();
            foreach (var coursedir in new DirectoryInfo("data").GetDirectories())
            {
                // create new course
                var course = new Course(coursedir);
                
                CourseList.Add(course);
                //append course to list
            }
        }

    }

    public class Course
    {
        public int courseNumber { get; set; }
        public string courseTitle { get; set; }
        public int courseName { get; set; }
        public List<Lesson> lessonList { get; }

        public Course(DirectoryInfo coursedir)
        {
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

    public class Lesson
    {
        public int lessonNumber { get; }
        public string lessonTitle { get; }
        public FileInfo lessonFile { get; }

        public Lesson(FileInfo lessonfile)
        {
            lessonFile = lessonfile;
            lessonTitle = lessonfile.Name;

            //Need name of lesson
            //Location of lesson
        }
    }

}
