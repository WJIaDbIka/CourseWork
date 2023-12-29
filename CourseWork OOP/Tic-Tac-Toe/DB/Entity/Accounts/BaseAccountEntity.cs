using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Accounts;

namespace Tic_Tac_Toe.DB.Entity.Accounts
{
	public class BaseAccountEntity
	{
		public int Id { get; set; }
		public AccTypes Type { get; set; }
		public string Name { get; set; }
		public int Rating { get; set; }
		public List<HistoryEntity> history { get; set; }
	}
}
