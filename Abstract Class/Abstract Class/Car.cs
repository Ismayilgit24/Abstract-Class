using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
	internal class Car : Vehicle
	{
		public int DoorCount = 0;
		public bool IsElecticCar;

		public Car(string factoryname, string model, string color, decimal drivetime, decimal drivepath, int doorcount, bool iselecticcar ) : base(factoryname, model, color, drivetime, drivepath)
		{
			DoorCount = doorcount;
			IsElecticCar = iselecticcar;
			
		}

		public override string GetInfo()
		{
			return string.Concat(base.GetInfo(), " ", $"\nDoor Count: {DoorCount}\nIs Electric Car: {IsElecticCar}\n");
		}


		public override void AverageSpeed()
		{
			base.AverageSpeed();
		}

		public override string ToString()
		{
			return $"Factory Name: {FactoryName}\nModel: {Model}\n";
		}


		public override void DefineNatureHarmness(string type)
		{
			if(type == "Gasoline")
			{
                Console.WriteLine("High");
			}
			else if(type == "Electric")
			{
                Console.WriteLine("Low");
			}
			else if(type == "Motorless")
			{
                Console.WriteLine("None");
			}
		}
	}
}
