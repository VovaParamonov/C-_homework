using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sem_2__laba_2_lesson_6.enums;

namespace sem_2__laba_2_lesson_6
{
    class Manufacter : IManufacter
    {
        public manufacturers name { get; set; }
        public countries country { get; set; }
        public int countOfWorker { get; set; }

        public Manufacter()
        {
            name = manufacturers.sony;
            country = countries.Canada;
            countOfWorker = 10000;
        }

        public Manufacter(manufacturers _name, countries _country, int _countOfWorker)
        {
            name = _name;
            country = _country;
            countOfWorker = _countOfWorker;
        }
    }
}
