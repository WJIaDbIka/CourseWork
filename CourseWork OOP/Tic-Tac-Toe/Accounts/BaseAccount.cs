using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Accounts
{
	public enum AccTypes
	{
		CUMMON_ACCOUNT = 1,
		DOBLE_SCORE_ACCOUNT =2,
	}
	public abstract class BaseAccount
	{
		public int Id { get; set; }
		public AccTypes Type { get; set; }
		public string Name { get; set; }
		public int Rating {  get; set; }
		public List<History> history { get; set; }
		public BaseAccount(string name) 
		{
			Name = name;
			Rating = 0;
			history = new List<History>();
		}

		public abstract void WinGame();
	}
}
