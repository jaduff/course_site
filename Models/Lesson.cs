using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace course_site.Models
{
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
