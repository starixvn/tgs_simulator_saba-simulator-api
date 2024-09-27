using SabaSimulator.API.Models.BetResultCheck;
using SabaSimulator.API.Models.SabaPlusEndGame;
using SabaSimulator.API.Models.SabaPlusPlaceBet;
using System.Linq;

namespace SabaSimulator.API.Helper;

public static class BetResultCheckBuilder
{
	public static BetResultPayloadModel BuildBetResultByPlaceBet(SabaPlusPlaceBetRequest data)
		=> new BetResultPayloadModel
		{
			TicketNo = data?.Payload?.BetDataSet[0]?.TicketNo,
			OperatorCustId = data?.Payload?.OperatorCustId,
			GameRoundId = data?.Payload?.BetDataSet[0].GameRoundId,
			TransactionId = data?.Payload?.BetDataSet[0].TransactionId,
			Status = 0,
			ActualStake = data?.Payload?.BetDataSet[0].ActualStake,
			NetStake = data?.Payload?.BetDataSet[0].Stake,
			Odds = data?.Payload?.BetDataSet[0].Odds
		};


	public static  List<BetResultPayloadModel> BuildBetResultBySettle(SabaPlusEndGameRequest data)
		=> (from item in data?.Payload?.BetDataSet
				select new BetResultPayloadModel
				{
					TicketNo = item.TicketNo,
					OperatorCustId = data?.Payload?.OperatorCustId,
					GameRoundId = item.GameRoundId,
					TransactionId = item.TransactionId,
					Status  = 1,
					ActualStake = item.ActualStake,
					NetStake = item.NetStake,
					Odds = item.Odds,
				    Payout= item.Payout,
				    GameResult= item.GameResult,
				    OtherBetInfo= item.OtherBetInfo,
				    SettleDate= item.SettleDate,
				}).ToList();
}
