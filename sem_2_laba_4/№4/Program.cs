using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static Type type;
        static Student student;

        static void Main(string[] args)
        {
            student = new Student();
            //point1();
            //point2();
            //point3();
            point4();

            Console.ReadLine();
        }

        static void point1()
        {
            type = Type.GetType("_4.Student");

            // Getting information about fields
            FieldInfo[] fieldInfo = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            // GetMainInfoAboutField(fieldInfo);

            // Getting informatiion about properties
            PropertyInfo[] propertyInfo = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            // GetMainInfoAboutProperty(propertyInfo);

            // Getting informatiion about methods
            MethodInfo[] methodsInfo = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            GetMainInfoAboutMethod(methodsInfo);
        }

        static void point2()
        {
            type = student.GetType();

            #region Fields
            FieldInfo fieldInfo = type.GetField("NameFaculty",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            // Получение значения переменной
            Console.WriteLine("Получение значения переменной");
            string nameFaculty = (string)fieldInfo.GetValue(student);
            Console.WriteLine($"NameFaculty = {nameFaculty}");
            Console.WriteLine();

            // Установка значения переменной
            Console.WriteLine("Установка значения переменной");
            fieldInfo.SetValue(student, "Нефтегаз");
            student.StudentInfo();
            Console.WriteLine();
            #endregion 

            #region Properties
            PropertyInfo propertyInfo = type.GetProperty("Name",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            // Получение значения свойтва
            Console.WriteLine("Текущие значение свойтва");
            string name = (string)propertyInfo.GetValue(student);
            Console.WriteLine($"Name = {name}");
            Console.WriteLine();

            // Установка значения свойтва
            Console.WriteLine("Установка значения свойтва");
            propertyInfo.SetValue(student, "Анастасия");
            student.StudentInfo();
            #endregion 
        }

        static void point3()
        {
            type = student.GetType();

            //Call secure mathods without params
            MethodInfo methodInfo1 = type.GetMethod("eat", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            methodInfo1.Invoke(student, new object[] {});

            //Call private mathods without params
            MethodInfo methodInfo2 = type.GetMethod("study", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            methodInfo2.Invoke(student, new object[] { "мат. часть" });
        }

        static void point4()
        {
            type = student.GetType();

            // Getting all constructors from class
            ConstructorInfo[] constructorInfo = type.GetConstructors();

            List<Student> students = new List<Student>();
            // Creating instances of a class by calling constructors.
            foreach (var constructor in constructorInfo)
            {
                var person =
                (constructor.GetParameters().Length == 0)
                ? constructor.Invoke(new object[] { })
                : constructor.Invoke(new object[6] { "Олег", "Тверской", 20, "ФИТиКС", 2, "МО-181" });

                students.Add((Student)person);

            }

            foreach (var person in students)
            {
                person.StudentInfo();
                Console.WriteLine();
            }
        }

        //Вывод информации о полях
        static void GetMainInfoAboutField(FieldInfo[] fieldInfo)
        {
            for(int i = 0; i < fieldInfo.Length; i++)
            {
                Console.WriteLine(fieldInfo[i].Name);
                Console.WriteLine($"Статический член? {fieldInfo[i].IsStatic}");
                Console.WriteLine($"Приватный член? {fieldInfo[i].IsPrivate}");
                Console.WriteLine($"Открытый член? {fieldInfo[i].IsPublic}");
                Console.WriteLine();
            }
        }

        //Вывод информации о свойствах
        static void GetMainInfoAboutProperty(PropertyInfo[] propertyInfo)
        {
            for (int i = 0; i < propertyInfo.Length; i++)
            {
                Console.WriteLine(propertyInfo[i].Name);
                Console.WriteLine($"Есть ли в свойстве Get? {propertyInfo[i].CanRead}");
                Console.WriteLine($"Есть ли в свойстве Set? {propertyInfo[i].CanWrite}");
                Console.WriteLine();
            }
        }

        //Вывод информации о методах
        static void GetMainInfoAboutMethod(MethodInfo[] methodInfo)
        {
            for (int i = 0; i < methodInfo.Length; i++)
            {
                Console.WriteLine(methodInfo[i].Name);
            Console.WriteLine($"Тип возвращаемого значения {methodInfo[i].ReturnType.Name}");
            var parameters = methodInfo[i].GetParameters();
            Console.WriteLine("Принимаемые параметры");
            foreach (var parameter in parameters)
                Console.WriteLine($"{parameter.Name} - {parameter.ParameterType.Name}");

            Console.WriteLine();
            }
        }
    }
}
