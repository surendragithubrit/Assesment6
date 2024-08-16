using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Assesment
{
    internal class Linq
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Enrollment
        {
            public int StudentId { get; set; }
            public string Course { get; set; }
        }

        
        
            static void Main(string[] args)
            
            {
                try
                {

                   List<Student> students = new List<Student>
                   {
                        new Student { Id = 1, Name = "Surendra" },
                        new Student { Id = 2, Name = "Ravi" },
                        new Student { Id = 3, Name = "Sai" }
                   };


                   List<Enrollment> enrollments = new List<Enrollment>
                   {
                        new Enrollment { StudentId = 1, Course = "Math" },
                        new Enrollment { StudentId = 2, Course = "English" },
                        new Enrollment { StudentId = 3, Course = "Science" },
                        new Enrollment { StudentId = 1, Course = "Social" }
                   };

                   var studentCourses = from student in students
                                         join enrollment in enrollments
                                         on student.Id equals enrollment.StudentId
                                         select new
                                         {
                                             StudentName = student.Name,
                                             Course = enrollment.Course
                                         };


                    foreach (var item in studentCourses)
                    {
                        Console.WriteLine($"{item.StudentName} is enrolled in {item.Course}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
    
            }
    }
    
}
