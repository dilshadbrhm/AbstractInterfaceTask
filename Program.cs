using AbstractInterfaceTask.Models;

namespace AbstractInterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Car
            {
                FactoryName = "tesla",
                Model = "s",
                Color = "red",
                DriveTime = 2,
                DrivePath = 100,
                DoorCount = 4,
                IsElectricCar = true
            };
            Vehicle car2 = new Car
            {
                FactoryName = "bmw",
                Model = "m5",
                Color = "black",
                DriveTime = 3,
                DrivePath = 300,
                DoorCount = 4,
                IsElectricCar = false
            };
            Vehicle bike1 = new Bicycle
            {
                FactoryName = "test",
                Model = "test",
                Color = "blue",
                DriveTime = 2,
                DrivePath = 20,
                Type = "test"
            };
            Vehicle[] vehicles = { car1, car2, bike1 };

            foreach (var v in vehicles)
            {
                v.GetInfo();
            }
            }
    }
}
