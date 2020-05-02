using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_2__laba_1
{
    interface StudientInterface
    {
        string GetStudentInfo();

        bool GetDecision();
    }

    public class Student : StudientInterface
    {
        static string[] firstNameArr = new string[] { "Андрей", "Владимир", "Дмитрий", "Гриша", "Олег" };
        static string[] lastNameArr = new string[] { "Бугаев", "Парамонов", "Буахлов", "Петин", "Тверской" };
        static string[] otchestvoArr = new string[] { "Сергеевич", "Викторович", "Андреевич", "Дмитриевич", "Александрович" };

        static int randomCounter = 0;

        public static Student generateStudent()
        {
            return new Student();
        }

        public string GetStudentInfo()
        {
            return "Имя: " + this.firstName + "\n\r" +
                "Фамилия: " + this.lastName + "\n\r" +
                "Отчество: " + this.otchestvo + "\n\r" +
                "Программирование: " + this.programming + "\n\r" +
                "Философия: " + this.philosofiya + "\n\r" +
                "Сети: " + this.networks + "\n\r" +
                "Пение: " + this.singing + "\n\r" +
                "Отчисление: " + this.GetDecision();
        }

        public bool GetDecision()
        {
            if (this.programming < 3 || this.philosofiya < 3 || this.singing < 3 || this.networks < 3) return true;
            return false;
        }

        public Student()
        {
            Random rand = new Random(Student.randomCounter);
            Student.randomCounter++;

            int randomNameid = rand.Next(firstNameArr.Length);
            int randLastNameid = rand.Next(lastNameArr.Length);
            int randOtchestvoid = rand.Next(otchestvoArr.Length);


            this.setValues(
                Student.firstNameArr[randomNameid],
                Student.lastNameArr[randLastNameid],
                Student.otchestvoArr[randOtchestvoid],

                rand.Next(2, 6),
                rand.Next(2, 6),
                rand.Next(2, 6),
                rand.Next(2, 6)
                );
        }

        Student(
            string firstName,
            string lastName,
            string otchestvo,

            int programming,
            int philosofiya,
            int networks,
            int singing
            )
        {
            this.setValues(
                firstName,
                lastName,
                otchestvo,

                programming,
                philosofiya,
                networks,
                singing
                );
        }

        private void setValues(
            string firstName,
            string lastName,
            string otchestvo,

            int programming,
            int philosofiya,
            int networks,
            int singing
            )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.otchestvo = otchestvo;

            this.programming = programming;
            this.philosofiya = philosofiya;
            this.networks = networks;
            this.singing = singing;
        }
 
        public string firstName;
        public string lastName;
        public string otchestvo;

        public int programming;
        public int philosofiya;
        public int networks;
        public int singing;
    }

    class Program
    {
        static bool stringCompare(string str1, string str2, int leterId)
        {
            int firstLatter1 = (int)str1[leterId];
            int firstLatter2 = (int)str2[leterId];

            if (firstLatter2 < firstLatter1)
            {
                return true;
            } else if (firstLatter2 > firstLatter1)
            {
                return false;
            } else
            {
                if (str1.Length >= leterId && str2.Length >= leterId)
                {
                    return stringCompare(str1, str2, leterId + 1);
                } else
                {
                    return false;
                }
            }
        }
        static string[] BubbleSort(string[] mas)
        {
            string temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (stringCompare(mas[j], mas[j + 1], 0))
                    {
                        temp = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        static void Main(string[] args)
        {
            string[] firstNames = new string[] { "Андрей", "Владимир", "Дмитрий", "Гриша", "Олег" };
            string[] lastNames = new string[] { "Бугаев", "Парамонов", "Буахлов", "Петин", "Тверской" };

            string[] students = new string[lastNames.Length + firstNames.Length];

            int j = 0;
            for (int i = 0; i < students.Length; i+=2) // push names
            {
                students[i] = firstNames[j];
                j++;
            }

            j = 0;
            for (int i = 1; i < students.Length; i += 2) // push names
            {
                students[i] = lastNames[j];
                j++;
            }

            Console.WriteLine("Задание 1:");
            Console.WriteLine();

            foreach (string elem in students)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine();






            Console.WriteLine("Задание 2:");
            Console.WriteLine();

            foreach (string elem in lastNames)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("--------------------");

            BubbleSort(lastNames);

            foreach (string elem in lastNames)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine();





            Console.WriteLine("Задание 3:");
            Console.WriteLine();

            Queue < Student > studentList = new Queue<Student>();
            
            for (int i = 0; i < 5; i++)
            {
                studentList.Enqueue(Student.generateStudent());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(studentList.Dequeue().GetStudentInfo());

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
