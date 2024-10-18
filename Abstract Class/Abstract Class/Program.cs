namespace Abstract_Class
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Car Informations\n");
			Car car = new Car("Hyundai", "Sonata", "Black", 150, 100, 4, true);

			//Console.WriteLine(car.GetInfo());
			//car.AverageSpeed();

			Console.WriteLine(car.ToString());
			//car.DefineNatureHarmness("Gasoline");

			//Vehicle[] Car = { car };
			//foreach (Vehicle vehicle in Car)
			//{
			//	Console.WriteLine(car.GetInfo());
			//}

			Console.WriteLine("\nBicycle Informations\n");
			Bicycle bicycle = new Bicycle("Trek Bicycle Corporation", "Giant Defy Advanced", "Blue", 80, 200, "Electric");

			//Console.WriteLine(bicycle.GetInfo());
			//bicycle.AverageSpeed();

			Console.WriteLine(bicycle.ToString());
			//bicycle.DefineNatureHarmness("Motorless");



			//Vehicle[] Bicycle = {bicycle};
			//foreach(Vehicle vehicle in Bicycle)
			//{
			//             Console.WriteLine(bicycle.GetInfo());
			//}
		}
	}
}
