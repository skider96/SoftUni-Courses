using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{typeOfVehicle} {model} {color} {horsepower}"

            List<Car> cars = new List<Car>();
            List<string> listCarTypes = new List<string>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split(" ").ToArray();

                string typeOfVehicle = input[0];
                string model = input[1];
                listCarTypes.Add(typeOfVehicle);
                string color = input[2];
                int horsepower = int.Parse(input[3]);
                Car currentCar = new Car(typeOfVehicle, model, color, horsepower);
                cars.Add(currentCar);
            }

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                Car car = new Car(command);

                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Model == command)
                    {
                        Console.WriteLine(cars[i]);
                    }
                }
            }

            int cars = cars.Where(c => c.TypeOfVehicle == "car");
            



            /*
            format: "{typeOfVehicles} have average horsepower of {averageHorsepower}."
               The average horsepower is calculated by dividing
            the sum of the horsepower of all vehicles of the given type by
               the total count of all vehicles from that type.
            Format the answer to the second digit after the decimal point.*/
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
            var firstLetter = FirstLetterCapitalize(argType);
            argType = firstLetter + argType.Substring(1);
            TypeOfVehicle = argType;
            Model = argModel;
            Color = argColor;
            Horsepower = argHP;
        }

        private static char FirstLetterCapitalize(string argType)
        {
            char[] charsArgType = argType.ToCharArray();
            char firstLetter = char.ToUpper(charsArgType[0]);
            return firstLetter;
        }

        public Car(string argModel)
        {
            Model = argModel;
        }
        public override string ToString()
        {
            return $"Type: {TypeOfVehicle}\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
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
Ferrari
Ford
Man
Close the Catalogue
*/