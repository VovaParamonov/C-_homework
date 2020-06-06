using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Earth : Planet, IRotationAble
    {
        protected Earth() { }
        protected static Earth _instance = null;

        public static Earth Instance()
        {
            if (_instance == null)
            {   // Allocation of memory for a new object
                _instance = new Earth();
            }

            return _instance;
        }

        public void rotate()
        {
            Console.WriteLine("Земля вращается сейчас...");
        }
    }
}
