using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Models
{
    internal class Car : Vehicle
    {
        private byte _doorCount;

        public byte DoorCount
        {
            get { return DoorCount; }
            set
            {
                if (value>6)
                {
                    _doorCount = value;
                }
            }
        }
        public bool IsElectricCar = true;

        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine("Low");
            }
            else
            {
                Console.WriteLine("High");
            }
        }
        public Car(bool IsElectricCar)
        {

        }
    }
}
