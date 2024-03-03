using System;
namespace StudentCourses.Management
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "Raghad", 21),
                new Student(2, "Abeer", 30),
                new Student(3, "Rand", 27),
            };

            List<Course> courses = new List<Course>
            {
                new Course(101, "ASP.Net"),
                new Course(102, "Nodejs"),
                new Course(103, "PHP"),
            };

            List<StudentCourse> studentCourses = new List<StudentCourse>
            {
                  new StudentCourse(1, 101),
                new StudentCourse(2, 102),
                new StudentCourse(3, 103),
                new StudentCourse(1, 102),
            };

            var sortedStudents = students.OrderBy(student => student.StudentName);
            Console.WriteLine("List of students sorted in  ascending order  by their names:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"StudentId: {student.StudentId}, Name: {student.StudentName} , Age: {student.StudentAge}");
            }

            var greaterThan20 = students.Where(std => std.StudentAge > 20);
            Console.WriteLine("\nNames of students who are older than 20 years:");
            foreach (var student in greaterThan20)
            {
                Console.WriteLine($"Name: {student.StudentName}, Age: {student.StudentAge}");
            }

            double averageAge = students.Average(student => student.StudentAge);
            Console.WriteLine($"\nAverage age of all students: {averageAge}\n");
            
            var results = (from student in students
                           join sc in studentCourses on student.StudentId equals sc.StudentId
                           join c in courses on sc.CourseId equals c.CourseId
                           select new
                           {
                               student.StudentId,
                               student.StudentName,
                               c.CourseId,
                               c.CourseName
                           });

            Console.WriteLine(" After inner join: ");

            foreach (var result in results)
            {
                Console.WriteLine($"StudentId: {result.StudentId}, Name: {result.StudentName}, CourseId: {result.CourseId}, CourseName: {result.CourseName}");
            }

        }

    }
   

    
   


}