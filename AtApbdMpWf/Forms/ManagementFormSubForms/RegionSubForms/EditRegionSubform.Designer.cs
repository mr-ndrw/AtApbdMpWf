using System.Windows.Forms;

namespace AtApbdMpWf.Forms.ManagementFormSubForms.RegionSubForms
{
	partial class EditRegionSubform : Form
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
			this.RegionNameTextBox = new System.Windows.Forms.TextBox();
			this.ExitButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(37, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// RegionNameTextBox
			// 
			this.RegionNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RegionNameTextBox.Location = new System.Drawing.Point(117, 20);
			this.RegionNameTextBox.Name = "RegionNameTextBox";
			this.RegionNameTextBox.Size = new System.Drawing.Size(252, 35);
			this.RegionNameTextBox.TabIndex = 0;
			// 
			// ExitButton
			// 
			this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ExitButton.Location = new System.Drawing.Point(12, 105);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(121, 38);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Exit [ESC]";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AddButton.Location = new System.Drawing.Point(248, 105);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(121, 38);
			this.AddButton.TabIndex = 3;
			this.AddButton.Text = "Update [Enter]";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// EditRegionSubform
			// 
			this.AcceptButton = this.AddButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ExitButton;
			this.ClientSize = new System.Drawing.Size(381, 155);
			this.ControlBox = false;
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.RegionNameTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "EditRegionSubform";
			this.Text = "Add new Region";
			this.Load += new System.EventHandler(this.EditRegionSubform_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox RegionNameTextBox;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button AddButton;
	}
}