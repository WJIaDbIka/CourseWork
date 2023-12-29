using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Accounts;
using Tic_Tac_Toe.DB.Entity.Accounts;

namespace Tic_Tac_Toe.DB.Repository.Base
{
	public interface IAccountRepository
	{
		void Create(string name, AccTypes type);
		List<BaseAccountEntity> GetAll();
		BaseAccountEntity GetByName(string name);
		void Update(BaseAccountEntity account);
		void Delete(BaseAccountEntity account);
	}
}
