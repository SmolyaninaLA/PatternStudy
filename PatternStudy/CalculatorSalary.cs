using System;
using System.Collections.Generic;
using System.Text;

namespace PatternStudy
{
    public class CalculatorSalary : ICalculateInterest
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
