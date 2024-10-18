using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
	internal class Bicycle: Vehicle
	{
		public string Type;

		public Bicycle(string factoryname, string model, string color, decimal drivetime, decimal drivepath, string type) : base(factoryname, model, color, drivetime, drivepath)
		{
			Type = type;
		}

		public override string GetInfo()
		{
			return string.Concat(base.GetInfo(), " ", $"\nType: {Type}\n");
		}


		public override void AverageSpeed()
		{
			base.AverageSpeed();
		}
		public override string ToString()
		{
			return $"Factory Name: {FactoryName}\nModel: {Model} \n";
		}

		public override void DefineNatureHarmness(string type)
		{
			if (type == "Gasoline")
			{
				Console.WriteLine("High");
			}
			else if (type == "Electric")
			{
				Console.WriteLine("Low");
			}
			else if (type == "Motorless")
			{
				Console.WriteLine("None");
			}
			else
			{
                Console.WriteLine("Enter one of them : Gasoline/Electric/Motorless");
			}
		}
	}
}
