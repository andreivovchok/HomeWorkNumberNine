using System;
using HomeWorkNumberNine;

namespace MyCollectionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat() { Name = "Aurora" };
            Boat boat1 = new Boat() { Name = "Maria" };
            Boat boat2 = new Boat() { Name = "Viktory" };

            Car car = new Car() { Name = "BMW" };
            Car car1 = new Car() { Name = "Audi" };
            Car car2 = new Car() { Name = "KIA" };

            MyCollection<Boat> boats = new MyCollection<Boat>();
            boats.Add(boat);
            boats.Add(boat1);
            boats.Add(boat2);
            Console.WriteLine(boats.Count);
            Console.WriteLine(boats[1]);

            MyCollection<Car> cars = new MyCollection<Car>();
            cars.Add(car);
            cars.Add(car1);
            cars.Add(car2);
            Console.WriteLine(cars.Count);
            Console.WriteLine(cars[1]);


            


        }
    }
}
