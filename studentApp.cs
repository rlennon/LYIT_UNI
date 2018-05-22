using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIsplayList
{
    class Program
    {
        static void Main(string[] args)
        {
			// Developed by LYIT Student : L00131535 (Date: 16 May 2018) (Updated: 22 May 2018)
            List<StudentList.Student> studentList = new List<StudentList.Student>();
            StudentList.Student student1 = new StudentList.Student();
            student1.StudentName = "John Doe";
            student1.StudentNumber = "L000000001";
            student1.Course = "DevOps Software Engineering";
            studentList.Add(student1);
            Student student2 = new Student();
            student2.StudentName = "Mary Doe";
            student2.StudentNumber = "L000000002";
            student2.Course = "DevOps Software Engineering";
            studentList.Add(student2);

            foreach (StudentList.Student student in studentList)
            {
                Console.WriteLine("Student Name  : " + student.StudentName);
                Console.WriteLine("Student Number: " + student.StudentNumber);
                Console.WriteLine("Course        : " + student.Course);
                Console.WriteLine("------------------------------------------------");
            }
            Console.ReadKey();
        }
    }

}