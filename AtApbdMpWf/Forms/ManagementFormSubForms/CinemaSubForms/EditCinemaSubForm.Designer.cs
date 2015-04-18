using System.Windows.Forms;

namespace AtApbdMpWf.Forms.ManagementFormSubForms.RegionSubForms
{
	partial class EditCinemaSubForm : Form
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
			this.label1 = new System.Windows.Forms.Label();
			this.CinemaNameTextBox = new System.Windows.Forms.TextBox();
			this.ExitButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.AddressTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TelephoneTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(88, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// CinemaNameTextBox
			// 
			this.CinemaNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CinemaNameTextBox.Location = new System.Drawing.Point(168, 23);
			this.CinemaNameTextBox.Name = "CinemaNameTextBox";
			this.CinemaNameTextBox.Size = new System.Drawing.Size(256, 35);
			this.CinemaNameTextBox.TabIndex = 0;
			// 
			// ExitButton
			// 
			this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ExitButton.Location = new System.Drawing.Point(12, 150);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(99, 38);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Exit [ESC]";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AddButton.Location = new System.Drawing.Point(294, 150);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(130, 38);
			this.AddButton.TabIndex = 3;
			this.AddButton.Text = "Update [Enter]";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// AddressTextBox
			// 
			this.AddressTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AddressTextBox.Location = new System.Drawing.Point(168, 60);
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.Size = new System.Drawing.Size(256, 35);
			this.AddressTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(70, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 30);
			this.label2.TabIndex = 4;
			this.label2.Text = "Address:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(19, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 30);
			this.label3.TabIndex = 6;
			this.label3.Text = "TelephoneNo:";
			// 
			// TelephoneTextBox
			// 
			this.TelephoneTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TelephoneTextBox.Location = new System.Drawing.Point(168, 98);
			this.TelephoneTextBox.Mask = "000000000";
			this.TelephoneTextBox.Name = "TelephoneTextBox";
			this.TelephoneTextBox.Size = new System.Drawing.Size(155, 35);
			this.TelephoneTextBox.TabIndex = 2;
			// 
			// EditCinemaSubForm
			// 
			this.AcceptButton = this.AddButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ExitButton;
			this.ClientSize = new System.Drawing.Size(436, 194);
			this.ControlBox = false;
			this.Controls.Add(this.TelephoneTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AddressTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.CinemaNameTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "EditCinemaSubForm";
			this.Text = "Update Cinema";
			this.Load += new System.EventHandler(this.AddCinemaSubForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CinemaNameTextBox;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button AddButton;
		private TextBox AddressTextBox;
		private Label label2;
		private Label label3;
		private MaskedTextBox TelephoneTextBox;
	}
}