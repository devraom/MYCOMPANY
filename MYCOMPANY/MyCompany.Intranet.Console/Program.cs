using System;
using System.Collections.Generic;
using MyCompany.Intranet.Core;

namespace MyCompany.Intranet.Console
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            float Weight = 0;

            System.Console.WriteLine("Please enter the Weight");
            Single.TryParse(System.Console.ReadLine(), out Weight);

            var person = new Person(){weight = Weight};

            var service = new WeightService();
            var manager = new WeightManager(service); 

            var MarsWeight = manager.GetMarsWeight(person);

            System.Console.WriteLine($"Weight on Mars {MarsWeight.marsWeight}Kg");
        }
    }
}