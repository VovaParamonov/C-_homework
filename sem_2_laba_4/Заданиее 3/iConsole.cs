using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sem_2__laba_2_lesson_6.enums;

namespace sem_2__laba_2_lesson_6
{
    interface IConsole
    {
        processors Proc { get; }
        manufacturers Manuf { get; }
        carrier car { get; }
        string model { get; }
        int discSize { get; }
        List<string> games { get; }
        List<string> accounts { get; }

        bool softwareHacked { get; }
        bool hardwareHacked { get; }
    }
}
