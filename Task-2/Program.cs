namespace Task_2
{

    class Program
    {
        static void Main(string[] args)
        {
            // Car Object
            Car car = new Car
            {
                Brand = "Toyota",
                Speed = 180,
                Seats = 5
            };

            // Motorcycle Object
            Motorcycle bike = new Motorcycle
            {
                Brand = "Yamaha",
                Speed = 120,
                HasCarrier = true
            };

            // Demonstrate Car Methods
            Console.WriteLine("\n--- Car Details ---");
            car.Start();
            car.DisplayInfo();
            car.Stop();

            // Demonstrate Motorcycle Methods
            Console.WriteLine("\n--- Motorcycle Details ---");
            bike.Start();
            bike.DisplayInfo();
            bike.Stop();
        }
    }

}
