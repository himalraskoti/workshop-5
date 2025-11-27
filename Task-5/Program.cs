namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects
            Car car = new Car();
            Bike bike = new Bike();

            // Car actions
            Console.WriteLine("--- Car ---");
            car.Display();
            car.StartEngine();
            car.StopEngine();

            // Bike actions
            Console.WriteLine("\n--- Bike ---");
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();
        }
    }

}
