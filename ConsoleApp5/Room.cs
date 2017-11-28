using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Room
    {
        Room()
        {
            roomtemperature = new Temperature();
            roomsecurity = new Security();
            roommedia = new Media();
            roomelectricity = new Electricity();
        }
        public Electricity GetElect()
        {
            return roomelectricity;
        }
        public Temperature GetTemp()
        {
            return roomtemperature;
        }
        public Media GetMedia()
        {
            return roommedia;
        }
        public Security GetSecur()
        {
            return roomsecurity;
        }
        Temperature roomtemperature;
        Security roomsecurity;
        Media roommedia;
        Electricity roomelectricity;
    }
}
