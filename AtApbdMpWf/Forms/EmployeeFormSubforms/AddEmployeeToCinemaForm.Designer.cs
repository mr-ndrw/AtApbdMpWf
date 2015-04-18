namespace AtApbdMpWf.Forms.EmployeeFormSubforms
{
	partial class AddEmployeeToCinemaForm
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
			this.employeeNameSurnameLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CinemaComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.RegionNameLabel = new System.Windows.Forms.Label();
			this.OkButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// employeeNameSurnameLabel
			// 
			this.employeeNameSurnameLabel.AutoSize = true;
			this.employeeNameSurnameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.employeeNameSurnameLabel.Location = new System.Drawing.Point(24, 9);
			this.employeeNameSurnameLabel.Name = "employeeNameSurnameLabel";
			this.employeeNameSurnameLabel.Size = new System.Drawing.Size(40, 32);
			this.employeeNameSurnameLabel.TabIndex = 0;
			this.employeeNameSurnameLabel.Text = "\" \"";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(25, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Add this emlpoyee to:";
			// 
			// CinemaComboBox
			// 
			this.CinemaComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CinemaComboBox.FormattingEnabled = true;
			this.CinemaComboBox.Location = new System.Drawing.Point(30, 69);
			this.CinemaComboBox.Name = "CinemaComboBox";
			this.CinemaComboBox.Size = new System.Drawing.Size(189, 38);
			this.CinemaComboBox.TabIndex = 2;
			this.CinemaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "which is located in region:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// RegionNameLabel
			// 
			this.RegionNameLabel.AutoSize = true;
			this.RegionNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RegionNameLabel.Location = new System.Drawing.Point(28, 123);
			this.RegionNameLabel.Name = "RegionNameLabel";
			this.RegionNameLabel.Size = new System.Drawing.Size(63, 25);
			this.RegionNameLabel.TabIndex = 4;
			this.RegionNameLabel.Text = "label3";
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(197, 154);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 5;
			this.OkButton.Text = "Ok [Enter]";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ExitButton.Location = new System.Drawing.Point(13, 153);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 6;
			this.ExitButton.Text = "Exit [Esc]";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AddEmployeeToCinemaForm
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ExitButton;
			this.ClientSize = new System.Drawing.Size(284, 187);
			this.ControlBox = false;
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.RegionNameLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CinemaComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.employeeNameSurnameLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AddEmployeeToCinemaForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddEmployeeToCinemaForm";
			this.Load += new System.EventHandler(this.AddEmployeeToCinemaForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label employeeNameSurnameLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CinemaComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label RegionNameLabel;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button ExitButton;
	}
}