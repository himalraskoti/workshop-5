namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object of NepaliTeacher
            NepaliTeacher nepali = new NepaliTeacher();
            nepali.Name = "Mr. Sharma";

            Console.WriteLine("Nepali Teacher:");
            nepali.Teaching();      // overridden
            nepali.SalaryInfo();    // sealed method


            // Object of EnglishTeacher
            EnglishTeacher english = new EnglishTeacher();
            english.Name = "Ms. Johnson";

            Console.WriteLine("\nEnglish Teacher:");
            english.Teaching();     // uses base class version
            english.SalaryInfo();   // sealed method
        }
    }

}
