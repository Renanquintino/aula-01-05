using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto.Entities
{
    class Company : TaxPayer
    {
        public int Employees { get; set; }
        public Company(string name, double anualIncome, int employees ): base(name, anualIncome)
        {
            Employees = employees;
        }
        public override double Tax()
        {
            if (Employees <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;

            }
        }
    }
}
