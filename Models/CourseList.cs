using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace course_site.Models
{
    public class CourseList
    {
        // Need to read list of directories in a location
        // Return list of courses based on directory names
        // Need to read list of html files in a given directory
        // Return list of lessons based on file names
        // Need to read HTML into View from a given lesson

        //private List<Course> _courseList { get; set; }
        //private IEnumerator<Course> _courseList { get; set; }
        public SortedDictionary<int, Course> courseDict {get; set;}

        public CourseList()
        {
            SortedDictionary<int, Course> dict = new SortedDictionary<int, Course>();
            foreach (var coursedir in new DirectoryInfo("data").GetDirectories())
            {
                // create new course
                var course = new Course(coursedir);
                
                dict.Add(course.courseYear, course);
                //append course to list
            }
            //list.Sort(new Comparison<Course>((x, y) => x.courseYear.CompareTo(y.courseYear)));
            courseDict = dict;
        }

        public Course getCourse(int courseYear)
        {
            return courseDict[courseYear];
        }

    }



    

}
