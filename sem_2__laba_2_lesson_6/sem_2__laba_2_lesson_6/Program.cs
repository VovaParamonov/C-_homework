using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sem_2__laba_2_lesson_6.enums;

namespace sem_2__laba_2_lesson_6
{
    class Program
    {
        public static List<Console> consoles = Console.generate100();
        public static List<Manufacter> ListExsampleOfManufacter = new List<Manufacter> { new Manufacter(manufacturers.sony, countries.Canada, 105760), new Manufacter(manufacturers.sega, countries.USA, 203190), new Manufacter(manufacturers.microsoft, countries.Japan, 97800) };

        static void Main(string[] args)
        {

            task2();
            task3();
            task4();
            task5();
            task6();

            //System.Console.WriteLine("Test");
            System.Console.ReadKey();
        }
        public static void task2()
        {

            // Задание 2
            // 1)

            System.Console.WriteLine("Задание 2.1:");
            System.Console.WriteLine("{Отфильтровать по процессору}");
            IEnumerable<Console> FilteredConsoles1 =
                from console in consoles
                where console.Proc == processors.AMD
                select console;

            foreach (Console console in FilteredConsoles1)
            {
                System.Console.WriteLine(console.model);
                System.Console.WriteLine(console.Proc);
                System.Console.WriteLine();
            }

            System.Console.WriteLine("-----------------------------------");



            // 2)
            System.Console.WriteLine("Задание 2.2:");
            System.Console.WriteLine("{Отфильтровать по процессору и модели}");
            IEnumerable<Console> FilteredConsoles2 =
                from console in consoles
                where console.Proc == processors.AMD && console.model == "XBox"
                select console;

            foreach (Console console in FilteredConsoles2)
            {
                System.Console.WriteLine(console.model);
                System.Console.WriteLine(console.Proc);
                System.Console.WriteLine();
            }

            System.Console.WriteLine("-----------------------------------");

            // 3)
            System.Console.WriteLine("Задание 2.3:");
            System.Console.WriteLine("{Отфильтровать по аккаунтам}");


            IEnumerable<Console> FilteredConsoles3 =
                from console in consoles
                where new HashSet<string>(console.accounts).SetEquals(new List<string>() { "user" }) && console.discSize == 100
                select console;

            foreach (Console console in FilteredConsoles3)
            {
                System.Console.WriteLine(console.model);
                System.Console.WriteLine(console.Proc);
                System.Console.WriteLine(console.discSize);
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");


        }
        public static void task3()
        {
            // Задание 3
            // 1)
            System.Console.WriteLine("Задание 3.1:");
            System.Console.WriteLine("{Отсортирповать по процессору и компании}");


            IEnumerable<Console> SortedConsoles1 =
                from console in consoles
                orderby console.Proc, console.Manuf descending
                select console;

            foreach (Console console in SortedConsoles1)
            {
                System.Console.WriteLine(console.model);
                System.Console.WriteLine(console.Manuf);
                System.Console.WriteLine(console.Proc);
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");
        }
        public static void task4()
        {
            // Задание 4
            System.Console.WriteLine("Задание 4.1, 4.2, 4.3:");
            System.Console.WriteLine("{Selects...}");


            IEnumerable<processors> SelectProcFromConsoles =
                from console in consoles
                select console.Proc;

            foreach (processors proc in SelectProcFromConsoles)
            {
                System.Console.WriteLine(proc);
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");


            IEnumerable<int> SelectDiscFromConsoles =
                from console in consoles
                select console.discSize;

            foreach (int discSize in SelectDiscFromConsoles)
            {
                System.Console.WriteLine(discSize);
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");

            IEnumerable<List<string>> SelectAccountsFromConsoles =
                from console in consoles
                select console.accounts;

            foreach (List<string> accounts in SelectAccountsFromConsoles)
            {
                foreach (string acc in accounts)
                {
                    System.Console.WriteLine("- " + acc);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");
        }
        public static void task5()
        {
            // Задание 5
            var queryComputersByNameManufacter =
            from console in consoles
                // Пример Внутренненнего соединения двух таблиц по названию компании.
            join manufacter in ListExsampleOfManufacter on console.Manuf equals manufacter.name
            select new { console.Manuf, console.softwareHacked, manufacter.country, manufacter.countOfWorker };

            foreach (var i in queryComputersByNameManufacter)
            {
                System.Console.WriteLine(i.Manuf + " : " + i.softwareHacked + " : " + i.country + " : " + i.countOfWorker);
            } // Вывод в консоль

            System.Console.WriteLine("---------------------------------");
        }
        public static void task6()
        {
            // Задание 6
            System.Console.WriteLine("Задание 6");
            System.Console.WriteLine("{Расширяющий метод string удаляющий латин. буквы}");
            System.Console.WriteLine("Владимир Paramonov".LatinLetterDelete());
        }

        public static void task2Update()
        {

            // Задание 2 (update)
            System.Console.WriteLine("Задание 2 (update)");
            System.Console.WriteLine("{Переписать все задание с помощью расширяющих методов linq}");

            IEnumerable<Console> FilteredConsoles1 = consoles.Where(c => c.Proc == processors.AMD);

            foreach (Console console in FilteredConsoles1)
            {
                System.Console.WriteLine(console.model);
                System.Console.WriteLine(console.Proc);
                System.Console.WriteLine();
            }

            System.Console.WriteLine("-----------------------------------");



            // 2)
            System.Console.WriteLine("Задание 2.2:");
            System.Console.WriteLine("{Отфильтровать по процессору и модели}");
            IEnumerable<Console> FilteredConsoles2 = consoles.Where(c => c.Proc == processors.AMD && c.model == "XBox");

            foreach (Console console in FilteredConsoles2)
            {
                System.Console.WriteLine(console.model);
                System.Console.WriteLine(console.Proc);
                System.Console.WriteLine();
            }

            System.Console.WriteLine("-----------------------------------");

            // 3)
            System.Console.WriteLine("Задание 2.3:");
            System.Console.WriteLine("{Отфильтровать по аккаунтам}");


            IEnumerable<Console> FilteredConsoles3 = consoles.Where(c => new HashSet<string>(c.accounts).SetEquals(new List<string>() { "user" }) && c.discSize == 100);

            foreach (Console console in FilteredConsoles3)
            {
                System.Console.WriteLine(console.model);
                System.Console.WriteLine(console.Proc);
                System.Console.WriteLine(console.discSize);
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");
        }

        public static void task3Update()
        {
            // Задание 3 (update)
            System.Console.WriteLine("Задание 3 (update)");
            System.Console.WriteLine("{Переписать все задание с помощью расширяющих методов linq}");

            IEnumerable<Console> SortedConsoles1 = consoles.OrderBy(c => c.Proc).ThenByDescending(c => c.Manuf);

            foreach (Console console in SortedConsoles1)
            {
                System.Console.WriteLine(console.model);
                System.Console.WriteLine(console.Manuf);
                System.Console.WriteLine(console.Proc);
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");
        }

        public static void task4Update()
        {
            // Задание 4 (update)
            System.Console.WriteLine("Задание 4 (update)");
            System.Console.WriteLine("{Переписать все задание с помощью расширяющих методов linq}");

            IEnumerable<processors> SelectProcFromConsoles = consoles.Select(c => c.Proc);

            foreach (processors proc in SelectProcFromConsoles)
            {
                System.Console.WriteLine(proc);
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");


            IEnumerable<int> SelectDiscFromConsoles = consoles.Select(c => c.discSize);

            foreach (int discSize in SelectDiscFromConsoles)
            {
                System.Console.WriteLine(discSize);
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");

            IEnumerable<List<string>> SelectAccountsFromConsoles = consoles.Select(c => c.accounts);

            foreach (List<string> accounts in SelectAccountsFromConsoles)
            {
                foreach (string acc in accounts)
                {
                    System.Console.WriteLine("- " + acc);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------");
        }

        public static void task5Update()
        {
            // Задание 5 (update)
            System.Console.WriteLine("Задание 5 (update)");
            System.Console.WriteLine("{Переписать все задание с помощью расширяющих методов linq}");
            var queryComputersByNameManufacter = consoles.Join(ListExsampleOfManufacter,
                console => console.Manuf,
                manufacturer => manufacturer.name,
                (console, manuf) => new { console.Manuf, console.softwareHacked, manuf.country, manuf.countOfWorker }
                );

            foreach (var i in queryComputersByNameManufacter)
            {
                System.Console.WriteLine(i.Manuf + " : " + i.softwareHacked + " : " + i.country + " : " + i.countOfWorker);
            } // Вывод в консоль

            System.Console.WriteLine("---------------------------------");
        }

    }

   

    public static class StringExtension
    {
        public static string LatinLetterDelete(this string str)
        {
            // Select only those characters that are numbers  
            var stringQuery =
              from ch in str
              where (int)ch > 127
              select ch;

            var sb = new StringBuilder();
            foreach (var c in stringQuery)
            {
                sb.Append(c.ToString());
            }
            return sb.ToString();
        }
    }
}
