namespace Application.Services.Operators
{
    public interface IOperator
    {
        public void TopUpBalance(string telephoneNumber, int amount);
    }
}
