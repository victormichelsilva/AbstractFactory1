using System;

namespace AbstractFactory1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarmaker factory = new HondaFactory();
            ISedan sedan = factory.CreateSedan();
            ISuv suv = factory.CreateSuv();
            Console.WriteLine("***** HONDA *****");
            ShowDetails(sedan, suv);

            factory = new HyundaiFactory();
            sedan = factory.CreateSedan();
            suv = factory.CreateSuv();
            Console.WriteLine("***** HYUNDAI *****");
            ShowDetails(sedan, suv);
        }

        private static void ShowDetails(ISedan sedan, ISuv suv)
        {
            Console.WriteLine(sedan.ShowDetails());
            Console.WriteLine(suv.ShowDetails());
        }
    }
}
