

using Microsoft.AspNetCore.Mvc;
using SabaSimulator.API.Models.CancelBet;
using SabaSimulator.API.Models.ConfirmBet;
using SabaSimulator.API.Models.PlaceBet;
using Tgs.ServiceUtility;

namespace SabaSimulator.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
    public class SimulatorController : ControllerBase
    {
        [HttpPost("PlaceBet")]
        public async Task<PlaceBetResult> PlaceBet(
			[FromServices] IGetService<PlaceBetRequest, PlaceBetResult> service,
			PlaceBetRequest source)
        {
			var result = await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);

			return result;
        }

		[HttpPost("ConfirmBet")]
		public async Task<ConfirmBetResult> ConfirmBet(
	    [FromServices] IGetService<ConfirmBetRequest, ConfirmBetResult> service,
		ConfirmBetRequest source)
		{
			var result = await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);

			return result;
		}

		[HttpPost("CancelBet")]
		public async Task<CancelBetResult> CancelBet(
			[FromServices] IGetService<CancelBetRequest, CancelBetResult> service,
			CancelBetRequest source)
		{
			var result = await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);

			return result;
		}
	}
}
