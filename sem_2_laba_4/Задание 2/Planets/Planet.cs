using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Planet : IRotationAble
    {
        protected Planet() {}
        protected static Planet _instance = null;

        public static Planet Instance()
        {
            if (_instance == null)
            {   // Allocation of memory for a new object
                _instance = new Planet();
            }

            return _instance;
        }

        public void rotate()
        {
            Console.WriteLine("Эта планета вращается сейчас...");
        }
    }
}
