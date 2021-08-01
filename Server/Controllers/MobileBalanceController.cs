using Application.Commands.TopUpBalance;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Models;
using System;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MobileBalanceController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public MobileBalanceController(IMediator mediatr)
        {
            _mediatr = mediatr ?? throw new ArgumentNullException(nameof(mediatr));
        }

        [HttpPost]
        public async Task<JsonResult> TopUpBalance([FromBody] TopUpBalanceModel model)
        {
            var response = await _mediatr.Send(new TopUpBalanceCommand
            {
                PhoneNumber = model.PhoneNumber,
                Amount = model.Amount,
                OperatorType = model.OperatorType
            });
            return new JsonResult(response);
        }
    }
}
