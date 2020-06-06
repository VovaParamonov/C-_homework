using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Venus : Planet, IRotationAble
    {
        protected Venus() { }
        protected static Venus _instance = null;

        public static Venus Instance()
        {
            if (_instance == null)
            {   // Allocation of memory for a new object
                _instance = new Venus();
            }

            return _instance;
        }

        public void rotate()
        {
            Console.WriteLine("Венера вращается сейчас...");
        }
    }
}
