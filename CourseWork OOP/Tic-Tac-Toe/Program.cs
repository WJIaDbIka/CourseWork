using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.DB;
using Tic_Tac_Toe.DB.Service;
using Tic_Tac_Toe.UI;

namespace Tic_Tac_Toe
{
	internal static class Program
	{
		
		[STAThread]
		static void Main()
		{
			DbContext dbContext = new DbContext();
			AccountService service = new AccountService(dbContext);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(service));
		}
	}
}
