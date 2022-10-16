// See https://aka.ms/new-console-template for more information
namespace Lab2_2
{
    public class Program
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new();

            vehicles.Add(new Plane()
            {
                PassengersCount = 4,
                Position = new Vector3(0, 0, 100),
                ProductionYear = 1990,
                Velocity = new Vector3(100, 150, 10)
            });

            vehicles.Add(new Car()
            {
                PassengersCount = 3,
                Position = new Vector3(0, 1, 0),
                ProductionYear = 2023,
                Velocity = new Vector3(0, 0, 0)
            });

            vehicles.Add(new Ship()
            {
                PassengersCount = 100,
                Position = new Vector3(0, 0, -50),
                ProductionYear = 1970,
                Velocity = new Vector3(40, 0, 0)
            });
                
            foreach(var v in vehicles)
            {
                Console.WriteLine($"{v}\n");
            }
        }
    }
}
