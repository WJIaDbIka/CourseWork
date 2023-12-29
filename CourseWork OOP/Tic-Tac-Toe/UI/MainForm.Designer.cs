namespace Tic_Tac_Toe.UI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.CreateAccBtn = new System.Windows.Forms.Button();
            this.CummounAccRadio = new System.Windows.Forms.RadioButton();
            this.DobleScoreAccRadio = new System.Windows.Forms.RadioButton();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.PlayerXCBox = new System.Windows.Forms.ComboBox();
            this.PlayerOCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dbContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateAccBtn
            // 
            this.CreateAccBtn.BackColor = System.Drawing.Color.White;
            this.CreateAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAccBtn.Location = new System.Drawing.Point(313, 126);
            this.CreateAccBtn.Name = "CreateAccBtn";
            this.CreateAccBtn.Size = new System.Drawing.Size(130, 44);
            this.CreateAccBtn.TabIndex = 0;
            this.CreateAccBtn.Text = "Create Account";
            this.CreateAccBtn.UseVisualStyleBackColor = false;
            this.CreateAccBtn.Click += new System.EventHandler(this.CreateAccBtn_Click);
            // 
            // CummounAccRadio
            // 
            this.CummounAccRadio.AutoSize = true;
            this.CummounAccRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CummounAccRadio.Location = new System.Drawing.Point(243, 73);
            this.CummounAccRadio.Name = "CummounAccRadio";
            this.CummounAccRadio.Size = new System.Drawing.Size(129, 20);
            this.CummounAccRadio.TabIndex = 1;
            this.CummounAccRadio.TabStop = true;
            this.CummounAccRadio.Text = "Cummon Account";
            this.CummounAccRadio.UseVisualStyleBackColor = true;
            this.CummounAccRadio.CheckedChanged += new System.EventHandler(this.CummounAccRadio_CheckedChanged);
            // 
            // DobleScoreAccRadio
            // 
            this.DobleScoreAccRadio.AutoSize = true;
            this.DobleScoreAccRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DobleScoreAccRadio.Location = new System.Drawing.Point(378, 73);
            this.DobleScoreAccRadio.Name = "DobleScoreAccRadio";
            this.DobleScoreAccRadio.Size = new System.Drawing.Size(152, 20);
            this.DobleScoreAccRadio.TabIndex = 2;
            this.DobleScoreAccRadio.TabStop = true;
            this.DobleScoreAccRadio.Text = "Doble Score Account";
            this.DobleScoreAccRadio.UseVisualStyleBackColor = true;
            this.DobleScoreAccRadio.CheckedChanged += new System.EventHandler(this.DobleScoreAccRadio_CheckedChanged);
            // 
            // NameTBox
            // 
            this.NameTBox.Location = new System.Drawing.Point(313, 36);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(130, 20);
            this.NameTBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Name";
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.White;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.Location = new System.Drawing.Point(172, 394);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(130, 44);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Start Game";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.BackColor = System.Drawing.Color.White;
            this.HistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryBtn.Location = new System.Drawing.Point(308, 394);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(130, 44);
            this.HistoryBtn.TabIndex = 6;
            this.HistoryBtn.Text = "Show History";
            this.HistoryBtn.UseVisualStyleBackColor = false;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.White;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(444, 394);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(130, 44);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // PlayerXCBox
            // 
            this.PlayerXCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerXCBox.FormattingEnabled = true;
            this.PlayerXCBox.Location = new System.Drawing.Point(181, 243);
            this.PlayerXCBox.Name = "PlayerXCBox";
            this.PlayerXCBox.Size = new System.Drawing.Size(121, 24);
            this.PlayerXCBox.TabIndex = 8;
            // 
            // PlayerOCBox
            // 
            this.PlayerOCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerOCBox.FormattingEnabled = true;
            this.PlayerOCBox.Location = new System.Drawing.Point(453, 243);
            this.PlayerOCBox.Name = "PlayerOCBox";
            this.PlayerOCBox.Size = new System.Drawing.Size(121, 24);
            this.PlayerOCBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(194, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(469, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Player O";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(331, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 55);
            this.label4.TabIndex = 12;
            this.label4.Text = "VS";
            // 
            // dbContextBindingSource
            // 
            this.dbContextBindingSource.DataSource = typeof(Tic_Tac_Toe.DB.DbContext);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerOCBox);
            this.Controls.Add(this.PlayerXCBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.HistoryBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.DobleScoreAccRadio);
            this.Controls.Add(this.CummounAccRadio);
            this.Controls.Add(this.CreateAccBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dbContextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CreateAccBtn;
		private System.Windows.Forms.RadioButton CummounAccRadio;
		private System.Windows.Forms.RadioButton DobleScoreAccRadio;
		private System.Windows.Forms.TextBox NameTBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.Button HistoryBtn;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.BindingSource dbContextBindingSource;
		private System.Windows.Forms.ComboBox PlayerXCBox;
		private System.Windows.Forms.ComboBox PlayerOCBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}