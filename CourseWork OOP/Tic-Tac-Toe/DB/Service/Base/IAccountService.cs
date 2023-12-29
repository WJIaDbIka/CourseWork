using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Accounts;

namespace Tic_Tac_Toe.DB.Service.Base
{
	public interface IAccountService
	{
		void Create(string name, AccTypes type);
		List<BaseAccount> GetAll();
		BaseAccount GetByName(string name);
		void Update(BaseAccount account);
		void Delete(BaseAccount account);
	}
}
