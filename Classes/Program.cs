using Microsoft.VisualBasic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Dodge";
            myCar.Model = "Challenger";
            myCar.Year = 2022;

            
            
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
            

        
        }
    }
}
