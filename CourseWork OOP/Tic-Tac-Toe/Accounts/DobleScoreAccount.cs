using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Accounts
{
	public class DobleScoreAccount : BaseAccount
	{
		public DobleScoreAccount(string name) : base(name) { }
		public override void WinGame()
		{
			Rating += 2;
		}
	}
}
