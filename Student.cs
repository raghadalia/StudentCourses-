using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourses
{
    class Student
    {
        private int _studentId;
        private string _studentName;
        private int _studentAge;

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public string StudentName
        {
            get { return _studentName; }
            set
            {
                _studentName = value;
            }
        }

        public int StudentAge
        {
            get { return _studentAge; }
            set { _studentAge = value; }
        }
        public Student(int studentId, string studentName, int studentAge)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentAge = studentAge;
        }

    }
}
