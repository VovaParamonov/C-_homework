using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Mercury : Planet, IRotationAble
    {
        protected Mercury() { }
        protected static Mercury _instance = null;

        public static Mercury Instance()
        {
            if (_instance == null)
            {   // Allocation of memory for a new object
                _instance = new Mercury();
            }

            return _instance;
        }

        public void rotate()
        {
            Console.WriteLine("Меркурий вращается сейчас...");
        }
    }
}
