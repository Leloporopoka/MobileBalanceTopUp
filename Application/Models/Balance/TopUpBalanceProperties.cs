using Application.Models.Operators.Enums;

namespace Application.Models.Balance
{
    public class TopUpBalanceProperties
    {
        public string PhoneNumber { get; set; }
        public int Amount { get; set; }
        public OperatorType OperatorType { get; set; }
    }
}
