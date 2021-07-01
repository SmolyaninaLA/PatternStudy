using System;
using System.Collections.Generic;
using System.Text;

namespace PatternStudy
{
    public class CalculatorNarmal : ICalculateInterest
    {
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
