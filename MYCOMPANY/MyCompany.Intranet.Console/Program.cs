using System;
using System.Collections.Generic;
using MyCompany.Intranet.Core;

namespace MyCompany.Intranet.Console
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            float Height = 0;
            float Weight = 0;

            System.Console.WriteLine("Please enter the Weight");
            Single.TryParse(System.Console.ReadLine(), out Weight);

            System.Console.WriteLine("Please enter the Height");
            Single.TryParse(System.Console.ReadLine(), out Height);

            var person = new Person(){weight = Weight, height = Height};

            var service = new BMIService();
            var manager = new BMIManager(service); 

            var BMI = manager.GetBMI(person);

            System.Console.WriteLine($"BMI {BMI.index} Type {BMI.BMIType}");
        }
    }
}
