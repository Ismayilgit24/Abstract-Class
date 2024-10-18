using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
	internal abstract class Vehicle
	{
		public string FactoryName ;
		public string Model;
		public string Color;
		public decimal DriveTime;
		public decimal DrivePath;

        protected Vehicle(string factoryname, string model, string color, decimal drivetime, decimal drivepath)
        {
			FactoryName = factoryname;
			Model = model;
			Color = color;
			DriveTime = drivetime;
			DrivePath = drivepath;
        }


		public virtual void AverageSpeed()
		{
            Console.WriteLine($"Average Speed is {DrivePath / DriveTime}");
		}


		public virtual string GetInfo()
		{
            return $"Factory Name: {FactoryName}\nModel: {Model}\nColor: {Color}\nDrive Time: {DriveTime}\nDrive Path: {DrivePath}"; 
		}


		public override string ToString()
		{
			return $"Factory Name: {FactoryName}\nModel: {Model}\n";
		}


		public abstract void DefineNatureHarmness(string type);
		
		

		
	}
}
