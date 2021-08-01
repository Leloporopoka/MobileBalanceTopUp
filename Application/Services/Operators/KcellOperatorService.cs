using System;

namespace Application.Services.Operators
{
    public class KcellOperatorService : IOperator
    {
        public void TopUpBalance(string telephoneNumber, int amount)
        {
            Console.WriteLine("Realization in KCell");
        }
    }
}
