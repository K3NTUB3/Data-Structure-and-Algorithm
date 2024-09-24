using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonTwo
    {
        public static void Lesson2()
        {
            Console.WriteLine("Enter the number of students:");
            int studentCount = int.Parse(Console.ReadLine());

            Student[] students = new Student[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("\nEnter the name of student " + (i + 1) + ": ");
                string studentName = Console.ReadLine();

                Console.WriteLine("Enter the number of grades for " + studentName + ": ");
                int numberOfGrades = int.Parse(Console.ReadLine());

                students[i] = new Student(studentName, numberOfGrades);

                for (int j = 0; j < numberOfGrades; j++)
                {
                    Console.WriteLine("Enter grade " + (j + 1) +" for " + studentName + ": ");
                    students[i].Grades[j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nStudent Average Grades:");
            foreach (var student in students)
            {
                double average = student.CalculateAverage();
                Console.WriteLine(student.Name +"'s average grade: "+ average);
            }

            Console.ReadKey();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, int numberOfGrades)
        {
            Name = name;
            Grades = new int[numberOfGrades];
        }
        public double CalculateAverage()
        {
            int sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }
            return (double)sum / Grades.Length;
        }
    }

}
