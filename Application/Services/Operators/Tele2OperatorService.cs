using System;

namespace Application.Services.Operators
{
    public class Tele2OperatorService : IOperator
    {
        public void TopUpBalance(string telephoneNumber, int amount)
        {
            Console.WriteLine("Realization in tele2");
        }
    }
}
