using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  
    public class Electricity
    {
        bool IsOn = false;
        public void SwitchOn()
        {
            IsOn = !IsOn;
            if(IsOn)
            {
                Console.WriteLine("свет включен");
            }
            else
            {
                Console.WriteLine("свет выключен");
            }
        }


    }
}
