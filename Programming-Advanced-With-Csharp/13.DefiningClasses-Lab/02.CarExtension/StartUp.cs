namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();

            car.Make = "Dacia";
            car.Model = "Sandero";
            car.Year = 2023;
            car.FuelQuantity = 33;
            car.FuelConsumption = 8.2;
           
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}