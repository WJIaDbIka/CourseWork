using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Accounts
{
	public class CummonAccount : BaseAccount
	{
		public CummonAccount(string name) : base(name) { }
		public override void WinGame()
		{
			Rating += 1;
		}
	}
}
