using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Accounts;
using Tic_Tac_Toe.DB.Service;

namespace Tic_Tac_Toe.UI
{
	public partial class MainForm : Form
	{
		AccountService service;
		AccTypes accType;
		public MainForm(AccountService service)
		{
			InitializeComponent();
			this.service = service;
			accType = AccTypes.CUMMON_ACCOUNT;
			UpdateCBoxData();
		}
		public void UpdateCBoxData()
		{
			this.PlayerXCBox.Items.Clear();
			this.PlayerOCBox.Items.Clear();
			foreach (var acc in service.GetAll())
			{
				this.PlayerXCBox.Items.Add(acc.Name);
				this.PlayerOCBox.Items.Add(acc.Name);
			}
		}

		private void CummounAccRadio_CheckedChanged(object sender, EventArgs e)
		{
			accType = AccTypes.CUMMON_ACCOUNT;
		}

		private void DobleScoreAccRadio_CheckedChanged(object sender, EventArgs e)
		{
			accType = AccTypes.DOBLE_SCORE_ACCOUNT;
		}

		private void CreateAccBtn_Click(object sender, EventArgs e)
		{
			service.Create(NameTBox.Text.Trim(), accType);
			NameTBox.Text = "";
			UpdateCBoxData();
		}

		private void ExitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			var Game = new GameUI(service, this, PlayerXCBox.Text, PlayerOCBox.Text);
			Game.Show();
			this.Visible = false;
		}

		private void HistoryBtn_Click(object sender, EventArgs e)
		{
			var histUi = new HistoryUI(service, this);
			histUi.Show();
			this.Visible = false;
		}
	}
}
