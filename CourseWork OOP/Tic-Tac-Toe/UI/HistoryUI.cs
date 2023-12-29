using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.DB.Service;

namespace Tic_Tac_Toe.UI
{
	public partial class HistoryUI : Form
	{
		Form prevForm;
		AccountService service;
		public HistoryUI(AccountService service, Form prevForm)
		{
			InitializeComponent();
			this.service = service;
			this.prevForm = prevForm;
			UpdateCBox();
		}

		public void UpdateCBox()
		{
			foreach (var acc in service.GetAll())
			{
				AccCBox.Items.Add(acc.Name);
			}
		}

		private void ExitBtn_Click(object sender, EventArgs e)
		{
			prevForm.Show();
			this.Dispose();
		}

		private void AccCBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			HistList.Items.Clear();
			var acc = service.GetByName(AccCBox.Text);
			if (acc.history == null)
			{
				return;
			}
			foreach (var hist in acc.history)
			{
				string[] row = { hist.PlayerX, hist.PlayerXScore.ToString(), hist.PlayerO, hist.PlayerOScore.ToString() };
				HistList.Items.Add(new ListViewItem(row));
			}
		}
	}
}
