using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Accounts;
using Tic_Tac_Toe.DB.Entity;
using Tic_Tac_Toe.DB.Entity.Accounts;
using Tic_Tac_Toe.DB.Repository;
using Tic_Tac_Toe.DB.Service.Base;

namespace Tic_Tac_Toe.DB.Service
{
	public class AccountService : IAccountService
	{
		AccountRepository repo;
		public AccountService(DbContext context)
		{
			repo = new AccountRepository(context);
		}

		public void Create(string name, AccTypes type)
		{
			repo.Create(name, type);
		}
		public List<BaseAccount> GetAll()
		{
			List<BaseAccountEntity> accounts = repo.GetAll();
			List<BaseAccount> newAccs = new List<BaseAccount>();
			foreach (var accountEntity in accounts)
			{
				switch (accountEntity.Type)
				{
					case AccTypes.CUMMON_ACCOUNT:
						newAccs.Add(new CummonAccount(accountEntity.Name)
						{
							Id = accountEntity.Id,
							Type = accountEntity.Type,
							Name = accountEntity.Name,
							Rating = accountEntity.Rating,
							history = MapHistory(accountEntity.history)
						});
						break;
					case AccTypes.DOBLE_SCORE_ACCOUNT:
						newAccs.Add(new DobleScoreAccount(accountEntity.Name)
						{
							Id = accountEntity.Id,
							Type = accountEntity.Type,
							Name = accountEntity.Name,
							Rating = accountEntity.Rating,
							history = MapHistory(accountEntity.history),
						});
						break;
				}
			}
			return newAccs;
		}

		public BaseAccount GetByName(string name)
		{
			var accountEntity = repo.GetByName(name);
			switch (accountEntity.Type)
			{
				case AccTypes.DOBLE_SCORE_ACCOUNT:
					return new DobleScoreAccount(accountEntity.Name)
					{
						Id = accountEntity.Id,
						Type = accountEntity.Type,
						Name = accountEntity.Name,
						Rating = accountEntity.Rating,
						history = MapHistory(accountEntity.history),
					};
				default:
					return new CummonAccount(accountEntity.Name)
					{
						Id = accountEntity.Id,
						Type = accountEntity.Type,
						Name = accountEntity.Name,
						Rating = accountEntity.Rating,
						history = MapHistory(accountEntity.history)
					};
			}
		}
		public void Update(BaseAccount account)
		{
			repo.Update(Map(account));
		}
		public void Delete(BaseAccount account)
		{
			repo.Delete(Map(account));
		}

		private BaseAccountEntity Map(BaseAccount account)
		{
			return new BaseAccountEntity
			{
				Id = account.Id,
				Type = account.Type,
				Name = account.Name,
				Rating = account.Rating,
				history = MapHistory(account.history)
			};
		}
		private CummonAccountEntity Map(CummonAccount account)
		{
			return new CummonAccountEntity
			{
				Id = account.Id,
				Type = account.Type,
				Name = account.Name,
				Rating = account.Rating,
				history = MapHistory(account.history)
			};
		}
		private DobleScoreAccountEntity Map(DobleScoreAccount account)
		{
			return new DobleScoreAccountEntity
			{
				Id = account.Id,
				Type = account.Type,
				Name = account.Name,
				Rating = account.Rating,
				history = MapHistory(account.history)
			};
		}

		private List<History> MapHistory(List<HistoryEntity> history)
		{
			if (history == null) { return null; }
			List<History> newHistory = new List<History>();
			foreach (var hist in history)
			{
				newHistory.Add(new History
				{
					PlayerX = hist.PlayerX,
					PlayerO = hist.PlayerO,
					PlayerXScore = hist.PlayerXScore,
					PlayerOScore = hist.PlayerOScore
				});
			}
			return newHistory;
		}
		private List<HistoryEntity> MapHistory(List<History> history)
		{
			if (history == null) { return null; }
			List<HistoryEntity> newHistory = new List<HistoryEntity>();
			foreach (var hist in history)
			{
				newHistory.Add(new HistoryEntity
				{
					PlayerX = hist.PlayerX,
					PlayerO = hist.PlayerO,
					PlayerXScore = hist.PlayerXScore,
					PlayerOScore = hist.PlayerOScore
				});
			}
			return newHistory;
		}
	}
}
