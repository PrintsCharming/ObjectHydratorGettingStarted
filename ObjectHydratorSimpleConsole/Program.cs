﻿using System;
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
                .With(x=>x.Loc,new LocationGenerator())
                .GetList(5);
            foreach (var customer in customers)
            {
                Console.WriteLine("{0} {1} is {2} years old and can be phoned at {3} and their Lat is {4} and Long is {5}",
                    customer.FirstName,
                    customer.LastName,
                    customer.Age,
                    customer.PhoneNumber,
                    customer.Loc.Lat,
                    customer.Loc.Long);
            }

            Console.ReadLine();
        }
    }
}
