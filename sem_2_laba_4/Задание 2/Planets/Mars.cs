using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Mars : Planet, IRotationAble
    {
        protected Mars() { }
        protected static Mars _instance = null;

        public static Mars Instance()
        {
            if (_instance == null)
            {   // Allocation of memory for a new object
                _instance = new Mars();
            }

            return _instance;
        }

        public void rotate()
        {
            Console.WriteLine("Марс вращается сейчас...");
        }
    }
}
