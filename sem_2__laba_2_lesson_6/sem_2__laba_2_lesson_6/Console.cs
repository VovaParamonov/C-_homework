using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sem_2__laba_2_lesson_6.enums;

namespace sem_2__laba_2_lesson_6
{
    class Console : IConsole, IHack
    {
        static public Console generate()
        {
            return new Console();
        }

        static public List<Console> generate100()
        {
            List<Console> list = new List<Console>();
            for (int i = 0; i < 100; i++) list.Add(new Console());
            return list;
        }

        Console()
        {
            Random rand = new Random();

            Proc = (processors)rand.Next(3);
            Manuf = (manufacturers)rand.Next(5);
            car = (carrier)rand.Next(4);

            switch(Manuf)
            {
                case manufacturers.microsoft:
                    model = Models.microsoftModels[rand.Next(Models.microsoftModels.Length)];
                    break;
                case manufacturers.nintendo:
                    model = Models.nintendoModels[rand.Next(Models.nintendoModels.Length)];
                    break;
                case manufacturers.sega:
                    model = Models.segaModels[rand.Next(Models.segaModels.Length)];
                    break;
                case manufacturers.sony:
                    model = Models.sonyModels[rand.Next(Models.sonyModels.Length)];
                    break;
            } // Задание модели на основе производителя

            switch(rand.Next(3))
            {
                case 0:
                    discSize = 0;
                    break;
                case 1:
                    discSize = 100;
                    break;
                case 2:
                    discSize = 1000;
                    break;
            } // Задание случайного значения объема диска

            for(int i = 0; i <= Games.games.Length; i++)
            {
                Random subRandom = new Random(i);
                string randGame;
                do
                {
                    randGame = Games.games[subRandom.Next(Games.games.Length)];
                } while (games.Where(g => g == randGame).Count() != 0);

                games.Add(randGame);
            }

            accounts.Add("user");
        }

        Console(processors Proc, manufacturers Manuf, carrier car, List<string> games, int discSize, List<string> accounts )
        {
            this.Proc = Proc;
            this.Manuf = Manuf;
            this.car = car;
            this.games = games;
            this.discSize = discSize;
            this.accounts = accounts;
        }

        public processors Proc { get; private set; }
        public manufacturers Manuf { get; private set; }
        public carrier car { get; private set; }
        public string model { get; private set; }
        public int discSize { get; private set; }
        public List<string> games { get; private set; } = new List<string>();
        public List<string> accounts { get; private set; } = new List<string>();

        public bool softwareHacked { get; private set; } = false;
        public bool hardwareHacked { get; private set; } = false;

        public bool TtySoftwareHack() {
            Random rand = new Random();
            bool result = Convert.ToBoolean(rand.Next(2));
            if (result)
            {
                this.softwareHacked = true;
            }

            return result;
        }

        public bool TtyHardwareHack()
        {
            Random rand = new Random();
            bool result = Convert.ToBoolean(rand.Next(2));
            if (result)
            {
                this.hardwareHacked = true;
            }

            return result;
        }
    }
}
