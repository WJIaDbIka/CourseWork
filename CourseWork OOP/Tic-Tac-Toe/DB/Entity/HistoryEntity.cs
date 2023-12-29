using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.DB.Entity
{
	public class HistoryEntity
	{
		public string PlayerX { get; set; }
		public int PlayerXScore { get; set; }
		public string PlayerO { get; set; }
		public int PlayerOScore { get; set; }
	}
}
