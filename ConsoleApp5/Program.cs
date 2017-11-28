using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] rooms = new Room[4];
            int choise;
            Control control = new Control();
            control.changeElectricity(ref rooms[0]);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню 1-4");
                bool result = int.TryParse(Console.ReadLine(), out choise);
                switch (choise)
                {
                    case 1:

                        break;
                    default:
                        break;
                }
            }

        }
    }
}
