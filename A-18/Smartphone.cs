using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_18
{
    public class Smartphone : IConnectable, IRechargable, IDisplayable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }

        public Smartphone(string brand, string model)
        {
            Brand = brand;
            Model = model;
            IsConnected = false;
            BatteryLevel = 0;
        }

        public void Connect()
        {
            if (!IsConnected)
            {
                IsConnected = true;
            }
        }

        public void Charge(int minutes)
        {
            BatteryLevel += minutes;
            if (BatteryLevel > 100)
                BatteryLevel = 100;
        }

        public string Display()
        {
            return $"Brand: {Brand}, Model: {Model}, Battery Level: {BatteryLevel}%";
        }
    }
}
