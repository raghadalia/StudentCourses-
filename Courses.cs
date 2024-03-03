using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourses
{
    class Course
    {
        private int _courseId;
        private string _courseName;

        public int CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        public string CourseName
        {
            get { return _courseName; }
            set
            {
                _courseName = value;
            }
        }
        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }

    }

}
