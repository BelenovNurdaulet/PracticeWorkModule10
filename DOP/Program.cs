using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOP
{
    public interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }
        string GetName();
        string GetFullName();
        double GetAvgGrade();
    }

    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, string fullName, int[] grades)
        {
            Name = name;
            FullName = fullName;
            Grades = grades;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public double GetAvgGrade()
        {
            if (Grades.Length == 0)
            {
                return 0.0;
            }

            double sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }

            return sum / Grades.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            int[] studentGrades = { 71, 77, 71, 75, 78 };
            IStudent student = new Student("Нурик", "Беленов Нурдаулет", studentGrades);

            Console.WriteLine($"Имя: {student.Name}");
            Console.WriteLine($"Полное имя: {student.FullName}");
            Console.WriteLine($"Оценки: [{string.Join(", ", student.Grades)}]");
            Console.WriteLine($"Средний балл: {student.GetAvgGrade()}");
            Console.WriteLine("Чего хочет: Стипендию ");

        }
    }
}
