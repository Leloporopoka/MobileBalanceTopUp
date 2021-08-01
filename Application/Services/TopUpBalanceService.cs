using Application.Models.Balance;
using Application.Services.Operators;
using Application.Models.Operators.Enums;
using System;

namespace Application.Services
{
    public class TopUpBalanceService
    {
        private readonly BeelineOperatorService _beelineOperatorService;
        private readonly KcellOperatorService _kcellOperatorService;
        private readonly Tele2OperatorService _tele2OperatorService;

        public TopUpBalanceService(BeelineOperatorService beelineOperatorService, KcellOperatorService kcellOperatorService, Tele2OperatorService tele2OperatorService)
        {
            _beelineOperatorService = beelineOperatorService ?? throw new ArgumentNullException(nameof(beelineOperatorService));
            _kcellOperatorService = kcellOperatorService ?? throw new ArgumentNullException(nameof(kcellOperatorService));
            _tele2OperatorService = tele2OperatorService ?? throw new ArgumentNullException(nameof(tele2OperatorService));
        }

        public void TopUpBalance(TopUpBalanceProperties properties)
        {
            var mobileOperator = _getOperatorService(properties.OperatorType);
            mobileOperator.TopUpBalance(properties.PhoneNumber, properties.Amount);
        }

        private IOperator _getOperatorService(OperatorType type)
        {
            return type switch
            {
                OperatorType.Beeline => _beelineOperatorService,
                OperatorType.Kcell => _kcellOperatorService,
                OperatorType.Tele2 => _tele2OperatorService,
                OperatorType.Default => throw new ArgumentException("Operator type is Default"),
                _ => throw new ArgumentException("Undefined operator type"),
            };
        }
    }
}
