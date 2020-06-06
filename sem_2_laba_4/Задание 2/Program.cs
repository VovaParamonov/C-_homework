using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet[] solarSystem1 = new Planet[4];

            solarSystem1[0] = Mercury.Instance();
            solarSystem1[1] = Venus.Instance();
            solarSystem1[2] = Earth.Instance();
            solarSystem1[3] = Mars.Instance();

            Planet[] solarSystem2 = new Planet[4];

            solarSystem2[0] = Mercury.Instance();
            solarSystem2[1] = Venus.Instance();
            solarSystem2[2] = Earth.Instance();
            solarSystem2[3] = Mars.Instance();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Совпадают значения хешей у {i + 1} планеты в разных списках? {solarSystem1[i].GetHashCode() == solarSystem2[i].GetHashCode()}");
            }

            Console.ReadLine();
        }
    }
}
