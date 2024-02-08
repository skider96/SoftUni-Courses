
namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<int, List<Tire>> allTires = new Dictionary<int, List<Tire>>();

            int key = 0;
            string command;
            while ((command = Console.ReadLine()) != "No more tires")
            {
                List<Tire> tires = new();
                var input = command.Split().ToArray();
                Stack<int> year = new();
                Stack<double> pressure = new();
                for (int i = 0; i < 8; i++)
                {
                    if (i % 2 != 1)
                    {
                        year.Push(int.Parse(input[i]));
                    }
                    else
                    {
                        pressure.Push(double.Parse(input[i]));
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    int popedYear = year.Pop();
                    double popedPressure = pressure.Pop();
                    var tire = new Tire(popedYear, popedPressure);
                    tires.Add(tire);
                }

                allTires.Add(key, tires);
                key++;
            }

            List<Engine> engines = new List<Engine>();

            while ((command = Console.ReadLine()) != "Engines done")
            {
                int horsePower = 0;
                double cubicCapacity = 0;

                var input = command.Split().ToArray();
                horsePower = int.Parse(input[0]);
                cubicCapacity = double.Parse(input[1]);
                Engine engine = new(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            List<Car> cars = new();
            int index = 0;
            while ((command = Console.ReadLine()) != "Show special")
            {
                var input = command.Split().ToArray();
                string make = input[0];
                string model = input[1];
                int year = int.Parse(input[2]);
                double fuelCapacity = double.Parse(input[3]);
                int fuelConsumption = int.Parse(input[4]);
                int engineIndex = int.Parse(input[5]);
                int tiresIndex = int.Parse(input[6]);

                double fuelQuantity = fuelCapacity - 20 * (double)fuelConsumption / 100;

                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], allTires[tiresIndex].ToArray());

                cars.Add(car);

                index++;
            }

            var specialCars = cars.FindAll(c =>
                   {
                       return c.Year >= 2017 && c.Engine.HorsePower > 330 && c.Tires.Sum(p => p.Pressure) >= 9 && c.Tires.Sum(p => p.Pressure) <= 10;
                   });

            foreach (var car in specialCars)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}