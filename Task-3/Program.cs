namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            printer.Print("Hello World");     // Calls Print(string)
            printer.Print(123);               // Calls Print(int)
            printer.Print("Repeated Text", 3); // Calls Print(string, int)
        }
    }


}
