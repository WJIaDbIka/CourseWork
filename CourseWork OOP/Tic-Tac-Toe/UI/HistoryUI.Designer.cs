namespace Tic_Tac_Toe.UI
{
	partial class HistoryUI
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
			this.HistList = new System.Windows.Forms.ListView();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.AccCBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// HistList
			// 
			this.HistList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.HistList.HideSelection = false;
			this.HistList.Location = new System.Drawing.Point(12, 61);
			this.HistList.Name = "HistList";
			this.HistList.Size = new System.Drawing.Size(776, 325);
			this.HistList.TabIndex = 0;
			this.HistList.UseCompatibleStateImageBehavior = false;
			this.HistList.View = System.Windows.Forms.View.Details;
			// 
			// ExitBtn
			// 
			this.ExitBtn.BackColor = System.Drawing.Color.White;
			this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ExitBtn.Location = new System.Drawing.Point(285, 392);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(212, 56);
			this.ExitBtn.TabIndex = 1;
			this.ExitBtn.Text = "Exit";
			this.ExitBtn.UseVisualStyleBackColor = false;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// AccCBox
			// 
			this.AccCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AccCBox.FormattingEnabled = true;
			this.AccCBox.Location = new System.Drawing.Point(412, 24);
			this.AccCBox.Name = "AccCBox";
			this.AccCBox.Size = new System.Drawing.Size(121, 24);
			this.AccCBox.TabIndex = 2;
			this.AccCBox.SelectedIndexChanged += new System.EventHandler(this.AccCBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Choose for which account to show the history:";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "PlayerX Name";
			this.columnHeader1.Width = 190;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "PlayerX Score";
			this.columnHeader2.Width = 190;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "PlayerO Name";
			this.columnHeader3.Width = 190;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "PlayerO Score";
			this.columnHeader4.Width = 190;
			// 
			// HistoryUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AccCBox);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.HistList);
			this.Name = "HistoryUI";
			this.Text = "HistoryUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView HistList;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.ComboBox AccCBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}