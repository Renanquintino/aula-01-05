using ExercicioProposto.Entities;
using System;

using System.Collections.Generic;
using System.Globalization;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? : ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anual, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employess = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anual, employess));

                }
            }
            double sum = 0.0;

            Console.WriteLine("TAXES PAID: ");
            Console.WriteLine();
            foreach (TaxPayer taxPayer in list)
            {

                Console.WriteLine(taxPayer.Name
                    + " $"
                    + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
             

                double tax = taxPayer.Tax();
                sum += tax;
            }
                Console.WriteLine();

                Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
