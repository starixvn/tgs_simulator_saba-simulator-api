using Microsoft.Extensions.Caching.Memory;
using Tgs.ServiceUtility;
using SabaSimulator.API.Models.BetResultCheck;

namespace SabaSimulator.API.Services;

public class BetResultCheckService : IGetService<BetResultCheckRequest, BetResultCheckResponse>
{
	private readonly IMemoryCache _memoryCache;

public BetResultCheckService(HttpClient httpClient, IConfiguration configuration, IMemoryCache memoryCache)
{
	_memoryCache = memoryCache;
}

	public async ValueTask< BetResultCheckResponse> GetAsync(BetResultCheckRequest query, CancellationToken cancellationToken = default)
	{
		string key = $"{query?.Payload?.TicketNo}";
		_ = _memoryCache.TryGetValue(key, out BetResultPayloadModel? value);
		if (value is not null)
		{
			var response = new BetResultCheckResponse
			{
				Seq = Guid.NewGuid().ToString(),
				ErrorCode = 0,
				ErrorMessage = "Success",
				TimeStamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"),
				Payload = value
			};

			return response;
		}
		return new BetResultCheckResponse
		{
			Seq = Guid.NewGuid().ToString(),
			ErrorCode = 3016,
			ErrorMessage = "No Such Ticket",
			TimeStamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"),
			Payload = null
		};

	}
}