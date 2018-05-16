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
			// Developed by LYIT Student : L00131535 (Date: 16 May 2018)
            List<Student> studentList = new List<Student>();
            Student student1 = new Student();
            student1.StudentName = "John Doe";
            student1.StudentNumber = "L000000001";
            student1.Course = "DevOps Software Engineering";
            studentList.Add(student1);
            Student student2 = new Student();
            student2.StudentName = "Mary Doe";
            student2.StudentNumber = "L000000002";
            student2.Course = "DevOps Software Engineering";
            studentList.Add(student2);

            foreach (Student student in studentList)
            {
                Console.WriteLine("Student Name  : " + student.StudentName);
                Console.WriteLine("Student Number: " + student.StudentNumber);
                Console.WriteLine("Course        : " + student.Course);
                Console.WriteLine("------------------------------------------------");
            }
            Console.ReadKey();
        }
    }

    public class Student
    {
        public string StudentName { get; set; }
        public string StudentNumber { get; set; }
        public string Course { get; set; }
    }
}