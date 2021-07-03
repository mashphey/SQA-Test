using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal cgpa { get; set; }
    }


    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.cgpa > y.cgpa)
            {
                return -1;
            }
            else if (x.cgpa < y.cgpa)
            {
                return 1;
            }


            if (string.Compare(x.name ,y.name) < 0)
            {
                return -1;
            }
            else if ((string.Compare(x.name, y.name) > 0))
            {
                return 1;
            }


            if (x.id < y.id)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = 0;
            string numberOfStudentsStr = Console.ReadLine();
            List<Student> students = new List<Student>();

            if (!string.IsNullOrEmpty(numberOfStudentsStr))
            {
                try
                {
                    numberOfStudents = Convert.ToInt32(numberOfStudentsStr);
                }
                catch (Exception ex)
                {} 
            }

            for(int i = 0; i< numberOfStudents; i++)
            {
                string studentInfo = Console.ReadLine();
                Student student = new Student();
                student.id = 1;

                string[] infos = studentInfo.Split(" ");
                
                if (infos.Length >= 3)
                {
                    student.id = Convert.ToInt32(infos[0]);
                    student.name = infos[1];
                    student.cgpa = Convert.ToDecimal(infos[2]);
                    students.Add(student);
                }

            }

            students.Sort(new StudentComparer());

            foreach (var student in students)
            {
                Console.WriteLine(student.name);
            }

        }
    }
}
