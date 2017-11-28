using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Control
    {
        public void changeElectricity(ref Room room)
        {
            room.GetElect().SwitchOn();
        }
        public void changeMedia(ref Room room)
        {
            room.GetMedia().SwitchOn();
        }
        public void changeVolume(ref Room room)
        {
            Console.WriteLine("выберите что вы хотите сделать: 1-увеличить\n2-уменьшить\n3-установить значение\n");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    room.GetMedia().IncreaseVolume();
                    break;
                case 2:
                    room.GetMedia().ReduceVolume();
                    break;
                case 3:
                    Console.WriteLine("введите значение? ");
                    int number2; 
                    bool result= int.TryParse(Console.ReadLine(),out number2);
                    if (result)
                        room.GetMedia().ChangeVolume(number2);
                    else
                        Console.WriteLine("не верно");
                    break;
                default:
                    Console.WriteLine("не верный выбор");
                    break;
            }
        }
        public int GetVolume(ref Room room)
        {
            return room.GetMedia().GetVolume();
        }
        
        public void ChangeState(ref Room room)
        {
            room.GetSecur().ChangeState();
        }
        public void ChangeTemperature(ref Room room)
        {
            Console.WriteLine("введите значение? ");
            int number2;
            bool result;
           result= int.TryParse(Console.ReadLine(), out number2);
            if (result)
                room.GetTemp().ChangeTemperature(number2);
            else
                Console.WriteLine("не верное значение");
        }
         public double GetTemperature(ref Room room)
         {
            return room.GetTemp().GetTemperature();
         }

    }
}
