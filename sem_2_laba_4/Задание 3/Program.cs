using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Computer cloneComputer = (Computer)computer.Clone();

            Console.WriteLine(computer.ComputerInfo());
            Console.WriteLine(cloneComputer.ComputerInfo());

            Console.ReadLine();
        }
    }
}
