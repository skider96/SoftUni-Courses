namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{typeOfVehicle} {model} {color} {horsepower}"

            List<Car> cars = new List<Car>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split(" ").ToArray();

                string typeOfVehicle = input[0];
                string model = input[1];
                string color = input[2];
                int horsepower = int.Parse(input[3]);
                Car currentCar = new Car(typeOfVehicle, model, color, horsepower);
                cars.Add(currentCar);
            }


            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {

                if (cars.Any(c => c.TypeOfVehicle == command))
                {
                    System.Console.WriteLine(string.Join("", cars.Where(c => c.TypeOfVehicle == command)));
                }
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
        public override string ToString()
        {
            return $"{TypeOfVehicle} {Model} {Color} {Horsepower}";
        }
    }
}
/*
truck Man red 200
truck Mercedes blue 300
car Ford green 120
car Ferrari red 550
car Lamborghini orange 570
End
*/