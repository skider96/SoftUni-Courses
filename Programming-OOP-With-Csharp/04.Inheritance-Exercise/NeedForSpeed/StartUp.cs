namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            FamilyCar car = new FamilyCar(20, 10);
            car.Drive(20);

            SportCar car1 = new SportCar(10, 10);
            car1.Drive(20);
        }
    }
}
