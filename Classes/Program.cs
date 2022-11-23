namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car dodge = new Car();    
            Car tesla = new Car();
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2011;

            tesla.Make = "Tesla";
            tesla.Model = "Sport";
            tesla.Year = 2022;

            dodge.Make = "Dodge";
            dodge.Model = "Charger";
            dodge.Year = 2016;

            var carList = new List<Car>() { myCar, tesla, dodge};

            foreach(var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
        }
    }
}
