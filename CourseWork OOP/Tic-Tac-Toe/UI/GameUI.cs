using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe.Accounts;
using Tic_Tac_Toe.DB.Service;

namespace Tic_Tac_Toe
{
	public partial class GameUI : Form
	{
		bool turn = true;
		int turnCount = 0;
		int PlayerXSc = 0;
		int PlayerOSc = 0;
		BaseAccount PlayerX;
		BaseAccount PlayerO;
		AccountService service;
		Form prevForm;

		public GameUI(AccountService service, Form prevForm, string PlayerX, string PlayerO)
		{
			InitializeComponent();
			DisableBtns();
			this.service = service;
			this.prevForm = prevForm;
			this.PlayerX = service.GetByName(PlayerX);
			this.PlayerO = service.GetByName(PlayerO);
			PlayerXLabel.Text = this.PlayerX.Name;
			PlayerOLabel.Text = this.PlayerO.Name;
		}
		private void UpdateScoreTable()
		{
			PlayerXScore.Text = PlayerXSc.ToString();
			PlayerOScore.Text = PlayerOSc.ToString();
		}

		private void DisableBtns()
		{
			btn1.Enabled = false;
			btn2.Enabled = false;
			btn3.Enabled = false;
			btn4.Enabled = false;
			btn5.Enabled = false;
			btn6.Enabled = false;
			btn7.Enabled = false;
			btn8.Enabled = false;
			btn9.Enabled = false;
		}

		private void EnableBtns()
		{
			btn1.Enabled = true;
			btn2.Enabled = true;
			btn3.Enabled = true;
			btn4.Enabled = true;
			btn5.Enabled = true;
			btn6.Enabled = true;
			btn7.Enabled = true;
			btn8.Enabled = true;
			btn9.Enabled = true;
		}

		private void ClearBtns()
		{
			btn1.Text = string.Empty;
			btn2.Text = string.Empty;
			btn3.Text = string.Empty;
			btn4.Text = string.Empty;
			btn5.Text = string.Empty;
			btn6.Text = string.Empty;
			btn7.Text = string.Empty;
			btn8.Text = string.Empty;
			btn9.Text = string.Empty;
		}

		private void ColorBtns()
		{
			btn1.BackColor = Color.White;
			btn2.BackColor = Color.White;
			btn3.BackColor = Color.White;
			btn4.BackColor = Color.White;
			btn5.BackColor = Color.White;
			btn6.BackColor = Color.White;
			btn7.BackColor = Color.White;
			btn8.BackColor = Color.White;
			btn9.BackColor = Color.White;
		}

		void BtnClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (turn)
			{
				if(btn != null)
				{
					btn.Text = @"X";
				}
			}
			else
			{
				if (btn != null)
				{
					btn.Text = @"O";
				}
			}
			
			if(btn != null)
			{
				btn.BackColor = Color.Silver;
				btn.Enabled = false;
			}

			++turnCount;
			CheckWinner();
			turn = !turn;
		}

		public void CheckWinner()
		{
			bool isWinner = false;
			if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
				isWinner = true;

			else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
				isWinner = true;
			else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
				isWinner = true; // verticals


			else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
				isWinner = true;
			else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
				isWinner = true;
			else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
				isWinner = true; //horizontal


			else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
				isWinner = true;
			else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn3.Enabled))
				isWinner = true; //diagonals



			string winner = "";
			if (turnCount == 9 && isWinner == false)
			{
				winner = "Nobody";
				MessageBox.Show(@"The winnner is " + winner, "TicTacToe", MessageBoxButtons.OK);
				ExitBtn.Enabled = true;
				StartBtn.Enabled = true;
			}
			if (isWinner)
			{
				if (turn && winner != "Nobody")
				{
					winner = PlayerX.Name;
					PlayerX.WinGame();
					PlayerXSc++;
				}
				else 
				{
					winner = PlayerO.Name;
					PlayerO.WinGame();
					PlayerOSc++;
				}
				DisableBtns();
				UpdateScoreTable();
				service.Update(PlayerX);
				service.Update(PlayerO);
				MessageBox.Show(@"The winnner is " + winner, "TicTacToe", MessageBoxButtons.OK);
				ExitBtn.Enabled = true;
				StartBtn.Enabled = true;
			}
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			ClearBtns();
			ColorBtns();
			EnableBtns();
			turnCount = 0;
			StartBtn.Enabled = false;
			ExitBtn.Enabled = false;
		}

		private void ExitBtn_Click(object sender, EventArgs e)
		{
			PlayerX.history.Add(new History
			{
				PlayerX = PlayerX.Name,
				PlayerXScore = PlayerXSc,
				PlayerO = PlayerO.Name,
				PlayerOScore = PlayerOSc,
			});
			PlayerO.history.Add(new History
			{
				PlayerX = PlayerX.Name,
				PlayerXScore = PlayerXSc,
				PlayerO = PlayerO.Name,
				PlayerOScore = PlayerOSc,
			});
			service.Update(PlayerX);
			service.Update(PlayerO);
			prevForm.Show();
			this.Dispose();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			BtnClick(sender, e);
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			BtnClick(sender, e);
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			BtnClick(sender, e);
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			BtnClick(sender, e);
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			BtnClick(sender, e);
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			BtnClick(sender, e);
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			BtnClick(sender, e);
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			BtnClick(sender, e);
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			BtnClick(sender, e);
		}
	}
}
