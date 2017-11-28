using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Media
    {
        bool isOn = false;
        int volume = 0;
        int maxVolume = 100;
        public void SwitchOn()
        {
            isOn = !isOn;
            if (isOn)
            {
                Console.WriteLine("музыка включена");
            }
            else
            {
                Console.WriteLine("музыка выключена");
            }
        }
        public void ChangeVolume(int volume)
        {
            this.volume = volume;
        }
        public void ReduceVolume()
        {
            if (volume > 0)
                volume--;
        }
        public void IncreaseVolume()
        {
            if(volume<maxVolume)
            {
                volume++;
            }
        }
        public int GetVolume()
        {
            return volume;
        }
    }
}
