using System;

namespace Application.Services.Operators
{
    public class BeelineOperatorService : IOperator
    {
        public void TopUpBalance(string telephoneNumber, int amount)
        {
            Console.WriteLine("Realization in Beeline");
        }
    }
}
