using Application.Models.Balance;
using Application.Models.Responses;
using MediatR;

namespace Application.Commands.TopUpBalance
{
    public class TopUpBalanceCommand : TopUpBalanceProperties, IRequest<Response>
    {
    }
}
