using System.Windows.Forms;

namespace AtApbdMpWf.Forms.ManagementFormSubForms.RegionSubForms
{
	partial class AddCinemaSubForm : Form
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
			this.label4 = new System.Windows.Forms.Label();
			this.RegionsComboBox = new System.Windows.Forms.ComboBox();
			this.ManagerComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
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
			this.ExitButton.Location = new System.Drawing.Point(12, 253);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(99, 38);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "Exit [ESC]";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AddButton.Location = new System.Drawing.Point(326, 253);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(98, 38);
			this.AddButton.TabIndex = 4;
			this.AddButton.Text = "Add [Enter]";
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
			this.TelephoneTextBox.Size = new System.Drawing.Size(138, 35);
			this.TelephoneTextBox.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(79, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 30);
			this.label4.TabIndex = 8;
			this.label4.Text = "Region:";
			// 
			// RegionsComboBox
			// 
			this.RegionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RegionsComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RegionsComboBox.FormattingEnabled = true;
			this.RegionsComboBox.Location = new System.Drawing.Point(168, 139);
			this.RegionsComboBox.Name = "RegionsComboBox";
			this.RegionsComboBox.Size = new System.Drawing.Size(256, 38);
			this.RegionsComboBox.TabIndex = 3;
			// 
			// ManagerComboBox
			// 
			this.ManagerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ManagerComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ManagerComboBox.FormattingEnabled = true;
			this.ManagerComboBox.Location = new System.Drawing.Point(168, 180);
			this.ManagerComboBox.Name = "ManagerComboBox";
			this.ManagerComboBox.Size = new System.Drawing.Size(256, 38);
			this.ManagerComboBox.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(13, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(149, 30);
			this.label5.TabIndex = 10;
			this.label5.Text = "New Manager:";
			// 
			// AddCinemaSubForm
			// 
			this.AcceptButton = this.AddButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ExitButton;
			this.ClientSize = new System.Drawing.Size(436, 303);
			this.ControlBox = false;
			this.Controls.Add(this.ManagerComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.RegionsComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TelephoneTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AddressTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.CinemaNameTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AddCinemaSubForm";
			this.Text = "Add Cinema";
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
		private Label label4;
		private ComboBox RegionsComboBox;
		private ComboBox ManagerComboBox;
		private Label label5;
	}
}