using System;
using System.Collections.Generic;
using FoundationStandard.ObjectHydrator;

namespace ObjectHydratorSimpleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new Hydrator<Customer>()
                .WithInteger(x=>x.Age,0,25)
                .WithUnitedKingdomLandline(x=>x.PhoneNumber)
                .GetList(5);
            foreach (var customer in customers)
            {
                Console.WriteLine("{0} {1} is {2} years old and can be phoned at {3}",
                    customer.FirstName,
                    customer.LastName,
                    customer.Age,
                    customer.PhoneNumber);
            }

            Console.ReadLine();
        }
    }
}
