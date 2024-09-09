using Microsoft.AspNetCore.Mvc;
using SabaSimulator.API.Models.Balance;
using SabaSimulator.API.Models.CancelBet;
using SabaSimulator.API.Models.ConfirmBet;
using SabaSimulator.API.Models.ConfirmbetParlay;
using SabaSimulator.API.Models.PlaceBet;
using SabaSimulator.API.Models.PlaceBetParlay;
using SabaSimulator.API.Models.Resettle;
using SabaSimulator.API.Models.Settle;
using SabaSimulator.API.Models.Unsettle;
using Tgs.ServiceUtility;

namespace SabaSimulator.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SimulatorController : ControllerBase
	{
		[HttpPost("PlaceBetParlay")]
		public async Task<PlaceBetParlayResult> PlaceBetParlay(
			[FromServices] IGetService<PlaceBetParlayRequest, PlaceBetParlayResult> service,
			PlaceBetParlayRequest source)
		{
			return await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);
		}

		[HttpPost("PlaceBet")]
		public async Task<PlaceBetResult> PlaceBet(
			[FromServices] IGetService<PlaceBetRequest, PlaceBetResult> service,
			PlaceBetRequest source)
		{
			var result = await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);

			return result;
		}

		[HttpPost("ConfirmBetParlay")]
		public async Task<ConfirmBetParlayResult> ConfirmBetParlay(
			[FromServices] IGetService<ConfirmBetParlayRequest, ConfirmBetParlayResult> service,
			ConfirmBetParlayRequest source)
		{
			return await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);
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

		[HttpPost("getBalance")]
		public async Task<GetBalanceResult> GetBalance(
		[FromServices] IGetService<GetBalanceRequest, GetBalanceResult> service,
		GetBalanceRequest source)
		{
			var result = await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);

			return result;
		}

		[HttpPost("settle")]
		public async Task<SettleResult> Settle(
		[FromServices] IGetService<SettleRequest, SettleResult> service,
		SettleRequest source)
		{
			var result = await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);

			return result;
		}

		[HttpPost("resettle")]
		public async Task<ResettleResult> Resettle(
		[FromServices] IGetService<ResettleRequest, ResettleResult> service,
		ResettleRequest source)
		{
			var result = await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);

			return result;
		}

		[HttpPost("unsettle")]
		public async Task<UnsettleResult> Unsettle(
		[FromServices] IGetService<UnsettleRequest, UnsettleResult> service,
		UnsettleRequest source)
		{
			var result = await service.GetAsync(source, cancellationToken: HttpContext.RequestAborted).ConfigureAwait(false);

			return result;
		}
	}
}