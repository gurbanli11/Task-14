using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Models
{
    internal class Bicycle : Vehicle
    {
        public string Type;
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("None");
        }
    }
}
