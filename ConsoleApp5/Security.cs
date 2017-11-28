using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Security
    {
        bool IsDoorOpen = false;
        public void ChangeState()
        {
            IsDoorOpen = !IsDoorOpen;
            if(IsDoorOpen)
            {
                Console.WriteLine("дверь открыта");
            }
            else
            {
                Console.WriteLine("дверь закрыта");
            }
            
        }
    }
}
