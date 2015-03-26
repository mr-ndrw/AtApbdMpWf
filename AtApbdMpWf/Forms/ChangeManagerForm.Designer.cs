﻿namespace AtApbdMpWf.Forms
{
	partial class ChangeManagerForm
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
			this.label5 = new System.Windows.Forms.Label();
			this.LabelCurrentlyViewedCinemaName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.LabelCurrentManager = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.ButtonUpdate = new System.Windows.Forms.Button();
			this.ComboBoxCinemaEmployees = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(128, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(225, 37);
			this.label5.TabIndex = 11;
			this.label5.Text = "Change Manager";
			// 
			// LabelCurrentlyViewedCinemaName
			// 
			this.LabelCurrentlyViewedCinemaName.AutoSize = true;
			this.LabelCurrentlyViewedCinemaName.BackColor = System.Drawing.SystemColors.Control;
			this.LabelCurrentlyViewedCinemaName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelCurrentlyViewedCinemaName.Location = new System.Drawing.Point(251, 46);
			this.LabelCurrentlyViewedCinemaName.Name = "LabelCurrentlyViewedCinemaName";
			this.LabelCurrentlyViewedCinemaName.Size = new System.Drawing.Size(102, 37);
			this.LabelCurrentlyViewedCinemaName.TabIndex = 13;
			this.LabelCurrentlyViewedCinemaName.Text = "cinema";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(132, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 37);
			this.label1.TabIndex = 12;
			this.label1.Text = "Cinema:";
			// 
			// LabelCurrentManager
			// 
			this.LabelCurrentManager.AutoSize = true;
			this.LabelCurrentManager.BackColor = System.Drawing.SystemColors.Control;
			this.LabelCurrentManager.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelCurrentManager.Location = new System.Drawing.Point(251, 83);
			this.LabelCurrentManager.Name = "LabelCurrentManager";
			this.LabelCurrentManager.Size = new System.Drawing.Size(122, 37);
			this.LabelCurrentManager.TabIndex = 15;
			this.LabelCurrentManager.Text = "manager";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(21, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 37);
			this.label3.TabIndex = 14;
			this.label3.Text = "Current Manager:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(93, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(280, 37);
			this.label2.TabIndex = 16;
			this.label2.Text = "Choose New Manager";
			// 
			// ButtonExit
			// 
			this.ButtonExit.Location = new System.Drawing.Point(100, 220);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(88, 38);
			this.ButtonExit.TabIndex = 18;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			// 
			// ButtonUpdate
			// 
			this.ButtonUpdate.Location = new System.Drawing.Point(282, 220);
			this.ButtonUpdate.Name = "ButtonUpdate";
			this.ButtonUpdate.Size = new System.Drawing.Size(91, 38);
			this.ButtonUpdate.TabIndex = 17;
			this.ButtonUpdate.Text = "Update";
			this.ButtonUpdate.UseVisualStyleBackColor = true;
			this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
			// 
			// ComboBoxCinemaEmployees
			// 
			this.ComboBoxCinemaEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxCinemaEmployees.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ComboBoxCinemaEmployees.FormattingEnabled = true;
			this.ComboBoxCinemaEmployees.Location = new System.Drawing.Point(100, 174);
			this.ComboBoxCinemaEmployees.Name = "ComboBoxCinemaEmployees";
			this.ComboBoxCinemaEmployees.Size = new System.Drawing.Size(273, 40);
			this.ComboBoxCinemaEmployees.TabIndex = 19;
			// 
			// ChangeManagerForm
			// 
			this.AcceptButton = this.ButtonUpdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 269);
			this.Controls.Add(this.ComboBoxCinemaEmployees);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.ButtonUpdate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LabelCurrentManager);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LabelCurrentlyViewedCinemaName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Name = "ChangeManagerForm";
			this.Text = "Change Manager";
			this.Load += new System.EventHandler(this.ChangeManagerForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label LabelCurrentlyViewedCinemaName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LabelCurrentManager;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button ButtonUpdate;
		private System.Windows.Forms.ComboBox ComboBoxCinemaEmployees;
	}
}