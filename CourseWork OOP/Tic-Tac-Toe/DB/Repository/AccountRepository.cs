using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Accounts;
using Tic_Tac_Toe.DB.Entity;
using Tic_Tac_Toe.DB.Entity.Accounts;
using Tic_Tac_Toe.DB.Repository.Base;

namespace Tic_Tac_Toe.DB.Repository
{
	public class AccountRepository : IAccountRepository
	{
		DbContext context;
		public AccountRepository(DbContext context)
		{
			this.context = context;
		}
		public void Create(string name, AccTypes type)
		{
			switch (type)
			{
				case AccTypes.CUMMON_ACCOUNT:
					context.accounts.Add(new CummonAccountEntity
					{
						Id = context.accounts.Count,
						Type = type,
						Name = name,
						Rating = 0,
						history = new List<HistoryEntity>(),
					});
					break;
				case AccTypes.DOBLE_SCORE_ACCOUNT:
					context.accounts.Add(new DobleScoreAccountEntity
					{
						Id = context.accounts.Count,
						Type = type,
						Name = name,
						Rating = 0,
						history = new List<HistoryEntity>(),
					});
					break;
			}
		}
		public List<BaseAccountEntity> GetAll()
		{
			return context.accounts;
		}
		public BaseAccountEntity GetByName(string name)
		{
			BaseAccountEntity account = null;
			foreach (var acc in context.accounts)
			{
				if (acc.Name == name)
				{
					account = acc;
					return account;
				}
			}
			if (account == null)
			{
				throw new InvalidOperationException($"No one account have name: {name}");
			}
			return account;
		}
		public void Update(BaseAccountEntity account)
		{
			context.accounts.RemoveAt(account.Id);
			context.accounts.Insert(account.Id, account);
		}
		public void Delete(BaseAccountEntity account)
		{
			context.accounts.RemoveAt(account.Id);
			int id = 0;
			foreach (var acc in context.accounts) { acc.Id = id; id++; }
		}
	}
}
