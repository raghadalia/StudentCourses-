using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourses
{
    class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public StudentCourse(int studentId, int courseId)
        {
            StudentId = studentId;
            CourseId = courseId;
        }

    }
}
