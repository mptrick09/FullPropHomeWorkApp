using System;

namespace ConsoleUIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonAddress address = new PersonAddress();
            address.City = "Hannover";
            address.State = "Niedersaschen";
            address.Street = " Kopernikustraßen 7";
            address.Zipcode = 300321;
            

            Console.WriteLine(address.FullAddress);
            

        }
    }
}
