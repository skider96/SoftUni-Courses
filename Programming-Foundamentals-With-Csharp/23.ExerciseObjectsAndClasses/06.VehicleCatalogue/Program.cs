namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{typeOfVehicle} {model} {color} {horsepower}"

            List<Car> cars = new List<Car>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" ").ToArray();
                
                 string typeOfVehicle = input[0];
                string model = input[1];
                string color = input[2];
                int horsepower = int.Parse(input[3]);
                Car currentCar = new Car(typeOfVehicle, model, color, horsepower);

                cars.Add(currentCar);

            }
           
            foreach (Car car in cars) 
            {
                System.Console.WriteLine($"{car.TypeOfVehicle} {car.Model} {car.Color} {car.Horsepower}");
            }
        }
    }

    class Car
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Car(string argType, string argModel, string argColor, int argHP)
        {
            TypeOfVehicle = argType;
            Model = argModel;
            Color = argColor;
            Horsepower = argHP;
        }
    }
}
