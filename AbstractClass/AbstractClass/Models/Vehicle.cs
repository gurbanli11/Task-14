using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Models
{
    internal abstract class Vehicle
    {
        public string FactoryName;
        public string Model;
        public string Color;
        public float DriveTime;
        public float DrivePath;
        public float Avarage;
        //public Vehicle(float drivePath, float driveTime)
        //{
        //    DriveTime = driveTime;
        //    DrivePath = drivePath;
 
        //}
        public static void AvarageSpeed(float drivePath, float driveTime)
        {
            float avarage = drivePath / driveTime;
        } 

        public virtual void GetInfo()
        {

        }

        public override string ToString()
        {
            return $"{FactoryName}" + $"{Model}"; 
        }
        public abstract void DefineNatureHarmness();
       
    }
}
