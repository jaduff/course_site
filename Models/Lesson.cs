using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace course_site.Models
{
    public class Lesson
    {
        public int courseYear { get; set; }
        public int lessonNumber { get; }
        public string lessonTitle { get; }
        public FileInfo lessonFile { get; }

        public Lesson(FileInfo lessonfile)
        {
            lessonFile = lessonfile;
            var nameList = lessonfile.Name.Split('-', '_', ' ', '.');
            lessonNumber = Int32.Parse(nameList[0]);

            lessonTitle = lessonNumber + " - ";

            if (nameList.Length > 1)
            {
                foreach (String _word in nameList.Skip(1).Take(nameList.Length-2))
                {
                    lessonTitle = lessonTitle + _word.First().ToString().ToUpper() + _word.Substring(1);
                }
            }
            else
            {
                lessonTitle = lessonTitle + "Untitled lesson";
            }

            //lessonTitle = lessonfile.Name;

            //Need name of lesson
            //Location of lesson
        }
    }
}
