using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Temperature
    {
        double temperature = 22;
        public double GetTemperature()
        {
            return temperature;
        }
        public void ChangeTemperature(double temperature)
        {
            this.temperature = temperature;
            Console.Write("температура была изменена - " + temperature);
        }
    }
}
