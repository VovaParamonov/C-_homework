using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Student
    {
        public string Name { get; set; }
        protected string SecondName { get; }
        private int Age { get; set; }

        public string NameFaculty;
        protected int NumberOfCourse;
        private string NameGroup;

        public static void sleep()
        {
            Console.WriteLine("Сплю...");
        }
        protected void eat()
        {
            Console.WriteLine("Ем...");
        }
        private void study(string subject)
        {
            Console.WriteLine($"Учу {subject}...");
        }

        public Student()
        {
            Name = "Владимир";
            SecondName = "Парамонов";
            Age = 20;
            NameFaculty = "ФИТиКС";
            NumberOfCourse = 2;
            NameGroup = "МО-181";
        }
        public Student(string name, string secondName, int age, string nameFaculty, int numberOfCourse, string nameGroup)
        {
            Name = name;
            SecondName = secondName;
            Age = age;

            NameFaculty = nameFaculty;
            NumberOfCourse = numberOfCourse;
            NameGroup = nameGroup;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"SecondName = {SecondName}");
            Console.WriteLine($"Age = {Age}");

            Console.WriteLine($"NameFaculty = {NameFaculty}");
            Console.WriteLine($"NumberOfCourse = {NumberOfCourse}");
            Console.WriteLine($"NameGroup = {NameGroup}");
        }
    }
}
