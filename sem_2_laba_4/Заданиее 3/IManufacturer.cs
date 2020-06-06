using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sem_2__laba_2_lesson_6.enums;

namespace sem_2__laba_2_lesson_6
{
    interface IManufacter
    {
        manufacturers name { get; set; }
        countries country { get; set; }
        int countOfWorker { get; set; }
    }
}
