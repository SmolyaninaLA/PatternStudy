using System;
using System.Collections.Generic;

namespace PatternStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new List<Account>()
            {
                new Account() {Type ="Обычный", Balance = 1200 },
                new Account() {Type ="Зарплатный", Balance = 15000 }
            };

            foreach (Account ac in account)
            {
                if (ac.Type == "Обычный")
                {
                    Calculate(new CalculatorNarmal(), ac);
                }
                if (ac.Type == "Зарплатный")
                {
                    Calculate(new CalculatorSalary(), ac);
                }
            }

        }

        public static void Calculate(ICalculateInterest calculateInterest, Account account )
        {
            calculateInterest.CalculateInterest(account);
            
        }
    }
}
