using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Задание_3
{
    public class Computer : ICloneable
    {
        public ProcessorType processorType { get; set; } //Тип процессора
        public NameManufacturer nameManufacturer { get; set; } // Название производителя
        public OperatingSystemType typeOfOperatingSystem { get; set; } // Тип операционной системы
        public int processClockSpeed { get; set; } // Тактовая частота процессов
        public int amountOfRAM { get; set; } // Объем оперативной памяти
        public List<string> InstalledSoftware; // Установленное ПО
        public List<string> UsersOfSystem; // Пользователи системы

        public static List<Computer> ListExsamleOfComputer; // Хранит экземпляры класса Computer

        public int method_only_one { get; set; }

        // Реализация интерфейса ICloneable
        public object Clone()
        {
            return new Computer()
            {
                processorType = this.processorType,
                nameManufacturer = this.nameManufacturer,
                typeOfOperatingSystem = this.typeOfOperatingSystem,
                processClockSpeed = this.processClockSpeed,
                amountOfRAM = this.amountOfRAM,
                InstalledSoftware = this.InstalledSoftware,
                UsersOfSystem = this.UsersOfSystem
            };
        }


        // Конструктор по умолчанию
        public Computer()
        {
            InstalledSoftware = new List<string>();
            UsersOfSystem = new List<string>();

            processorType = ProcessorType.Pentium;
            nameManufacturer = NameManufacturer.AMD;
            typeOfOperatingSystem = OperatingSystemType.Многопользовательские;
            processClockSpeed = 300;
            amountOfRAM = 8;
            InstalledSoftware.Add("Windows");
            UsersOfSystem.Add("Рогожина Екатерина");
        }

        // Конструктор с параметрами
        Computer(ProcessorType _processorType, NameManufacturer _nameManufacturer, OperatingSystemType _typeOfOperatingSystem,
                int _processClockSpeed, int _amountOfRAM, List<string> _InstalledSoftware, List<string> _UsersOfSystem)
        {
            InstalledSoftware = new List<string>();
            UsersOfSystem = new List<string>();

            processorType = _processorType;
            nameManufacturer = _nameManufacturer;
            typeOfOperatingSystem = _typeOfOperatingSystem;
            processClockSpeed = _processClockSpeed;
            amountOfRAM = _amountOfRAM;
            InstalledSoftware = _InstalledSoftware;
            UsersOfSystem = _UsersOfSystem;
        }

        // Метод, создающий один экземпляр класса
        public static Computer Generate()
        {
            Random rnd = new Random();
            ProcessorType _processorType = (ProcessorType)rnd.Next(4);
            NameManufacturer _nameManufacturer = (NameManufacturer)rnd.Next(3);
            OperatingSystemType _typeOfOperatingSystem = (OperatingSystemType)rnd.Next(4);
            int _processClockSpeed = rnd.Next(100, 1000);

            int _amountOfRAM = 0;
            int _amount = rnd.Next(4);
            switch (_amount)
            {
                case 0: _amountOfRAM = 2; break;
                case 1: _amountOfRAM = 4; break;
                case 2: _amountOfRAM = 8; break;
                case 3: _amountOfRAM = 16; break;
            }

            List<string> _InstalledSoftware = new List<string>();
            int _installedSoftware1 = rnd.Next(3);
            switch (_installedSoftware1)
            {
                case 0: _InstalledSoftware.Add("Windows"); break;
                case 1: _InstalledSoftware.Add("MAC"); break;
                case 2: _InstalledSoftware.Add("Linux"); break;
            }

            int _installedSoftware2 = rnd.Next(6);
            if (_installedSoftware1 != _installedSoftware2)
            {
                switch (_installedSoftware2)
                {
                    case 0: _InstalledSoftware.Add("Windows"); break;
                    case 1: _InstalledSoftware.Add("MAC"); break;
                    case 2: _InstalledSoftware.Add("Linux"); break;
                } // Второе установленное ПО (Может и не быть)
            }

            List<string> _UsersOfSystem = new List<string>();
            int _usersOfSystem1 = rnd.Next(8);
            switch (_usersOfSystem1)
            {
                case 0: _UsersOfSystem.Add("Рогожина"); break;
                case 1: _UsersOfSystem.Add("Досаева"); break;
                case 2: _UsersOfSystem.Add("Хрулев"); break;
                case 3: _UsersOfSystem.Add("Федосеева"); break;
                case 4: _UsersOfSystem.Add("Тверской"); break;
                case 5: _UsersOfSystem.Add("Пронникова"); break;
                case 6: _UsersOfSystem.Add("Грачев"); break;
                case 7: _UsersOfSystem.Add("Янцен"); break;
            }

            int _usersOfSystem2 = rnd.Next(16);
            if (_usersOfSystem1 != _usersOfSystem2)
                switch (_usersOfSystem2)
                {
                    case 0: _UsersOfSystem.Add("Рогожина"); break;
                    case 1: _UsersOfSystem.Add("Досаева"); break;
                    case 2: _UsersOfSystem.Add("Хрулев"); break;
                    case 3: _UsersOfSystem.Add("Федосеева"); break;
                    case 4: _UsersOfSystem.Add("Тверской"); break;
                    case 5: _UsersOfSystem.Add("Пронникова"); break;
                    case 6: _UsersOfSystem.Add("Грачев"); break;
                    case 7: _UsersOfSystem.Add("Янцен"); break;
                } // Второй пользователь (Может и не быть)

            return new Computer(_processorType, _nameManufacturer, _typeOfOperatingSystem, _processClockSpeed,
                                _amountOfRAM, _InstalledSoftware, _UsersOfSystem);
        }

        // Метод, создающий 100 экземпляров класса
        public static List<Computer> Generate100()
        {
            ListExsamleOfComputer = new List<Computer>();

            for (int i = 0; i < 100; i++)
            {
                ListExsamleOfComputer.Add(Generate());
                Thread.Sleep(100);
            }

            return ListExsamleOfComputer;
        }

        // Метод, возвращающий информацию об экземпляре
        public string ComputerInfo()
        {
            return string.Format("{0,10}  {1,5}  {2,21} ClockSpeed = {3,4} RAM = {4,4}  {5,16}  {6}", this.processorType, this.nameManufacturer, this.typeOfOperatingSystem, this.processClockSpeed, this.amountOfRAM, this.GetInstalledSoftware(), this.GetUsersOfSystem());
        }

        // Преобразование листов в строку для вывода
        public string GetInstalledSoftware()
        {
            if (this.InstalledSoftware.Count == 1)
                return string.Format(this.InstalledSoftware[0]);
            else
                return string.Format(this.InstalledSoftware[0] + " " + this.InstalledSoftware[1]);
        }
        public string GetUsersOfSystem()
        {
            if (this.UsersOfSystem.Count == 1)
                return string.Format(this.UsersOfSystem[0]);
            else
                return string.Format(this.UsersOfSystem[0] + " " + this.UsersOfSystem[1]);
        }

        // Метод, требуемый в условии
        public void OverclockTheComputer() // Нет проверки, что он может быть выполнен только один раз
        {
            if (method_only_one == 0)
            {
                method_only_one = 1;
                int Frequency = 0;
                switch (processorType)
                {
                    case ProcessorType.Pentium: Frequency += 200; break;
                    case ProcessorType.PentiumII: Frequency += 300; break;
                    case ProcessorType.PentiumIII: Frequency += 400; break;
                    case ProcessorType.PentiumPro: Frequency += 600; break;
                }
                Console.WriteLine("Frequency = {0}", Frequency);
            }
            else
                Console.WriteLine("Метод уже был вызван");
        }
    }
}
