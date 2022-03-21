using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student(1,"Luis","3363695",100),
                new Student(2,"Roberto","6652312",35),
                new Student(3,"Bianca","8541236",85),
                new Student(4,"Helena","85479625",70),
                new Student(5,"Luis","3201469",75)
            };

            var any = students.Any();
            var any100 = students.Any(s => s.Grade == 100);

            var single = students.Single(s => s.Id == 1);
            var singleOrDefault = students.SingleOrDefault(s => s.Document == "111111");

            var first = students.First(s => s.FullName == "Luis");
            var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

            var orderedByGrade = students.OrderBy(s => s.Grade);
            var orderedByGradeDescending = students.OrderByDescending(s => s.Grade);

            var aprovedStudents = students.Where(s => s.Grade >= 70);

            var grades = students.Select(s => s.Grade);
            var phoneNumbers = students.SelectMany(s => s.PhoneNumbers);

            var sum = students.Sum(s => s.Grade);
            var min = students.Min(s => s.Grade);
            var max = students.Max(s => s.Grade);



            Console.ReadKey();
        }

        public class Student
        {
            public Student(int id, string fullName, string document, int grade)
            {
                Id = id;
                FullName = fullName;
                Document = document;
                Grade = grade;

                PhoneNumbers = new List<string> { "123456", "25986547", "52525252" };
            }

            public int Id { get; set; }
            public string FullName { get; set; }
            public string Document { get; set; }
            public int Grade { get; set; }
            public List<string> PhoneNumbers { get; set; }
        }



    }
}
