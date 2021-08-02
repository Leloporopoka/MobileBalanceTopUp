using Application.Models.Balance;
using Application.Models.Responses;
using Application.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.TopUpBalance
{
    public class TopUpBalanceCommandHandler : IRequestHandler<TopUpBalanceCommand, Response>
    {
        private readonly TopUpBalanceService _topUpBalanceService;
        private readonly ILogger _logger;
        public TopUpBalanceCommandHandler(TopUpBalanceService topUpBalanceService, ILogger<TopUpBalanceCommandHandler> logger)
        {
            _topUpBalanceService = topUpBalanceService ?? throw new ArgumentNullException(nameof(topUpBalanceService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<Response> Handle(TopUpBalanceCommand request, CancellationToken cancellationToken)
        {
            try
            {
                _topUpBalanceService.TopUpBalance(new TopUpBalanceProperties
                {
                    PhoneNumber = request.PhoneNumber,
                    Amount = request.Amount,
                    OperatorType = request.OperatorType
                });
                _logger.LogInformation($"Баланс телефона {request.PhoneNumber} был пополнен на сумму {request.Amount}, оператор {request.OperatorType} ");
                return new Response { StatusCode = 200, Message = "Баланс успешно пополнен" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong  {ex.ToString() + ex.InnerException}");
                return new Response { StatusCode = 500, Message = "Произошла ошибка при пополнении баланса" };
            }
        }
    }
}
