using System;

namespace Task_6
{
    public abstract class ElectronicDevice
    {
        public string Brand { get; set; }
        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                price = value;
            }
        }

        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        public abstract void ShowInfo();
    }

    // Example subclass (required because abstract class cannot be created)
    public class MobilePhone : ElectronicDevice
    {
        public string Model { get; set; }

        public MobilePhone(string brand, double price, string model)
            : base(brand, price)
        {
            Model = model;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Price: {Price}");
        }
    }

    // Main Program Entry Point (Fixes your error)
    public class Program
    {
        public static void Main(string[] args)
        {
            MobilePhone phone = new MobilePhone("Samsung", 50000, "Galaxy S22");
            phone.ShowInfo();

            Console.ReadLine();
        }
    }
}
