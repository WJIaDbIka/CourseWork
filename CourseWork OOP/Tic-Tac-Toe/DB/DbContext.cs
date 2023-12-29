using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.DB.Entity.Accounts;

namespace Tic_Tac_Toe.DB
{
	public class DbContext
	{
		public List<BaseAccountEntity> accounts { get; set; }
		public DbContext() 
		{
			accounts = new List<BaseAccountEntity>();
		}
	}
}
