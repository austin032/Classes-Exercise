namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne =  new Car();
            carOne.Make = "BMW";
            carOne.Model = "M series";
            carOne.Year = 2024;
            
            Console.WriteLine($"You are looking at a {carOne.Year} {carOne.Make} {carOne.Model}.");
        }
    }
}
