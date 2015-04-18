namespace AtApbdMpWf.Forms.EmployeeFormSubforms
{
	partial class AddNewEmployeeForm
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
			this.ExitButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.CinemasComboBox = new System.Windows.Forms.ComboBox();
			this.TelephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.EmailTextBox = new System.Windows.Forms.MaskedTextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// ExitButton
			// 
			this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ExitButton.Location = new System.Drawing.Point(12, 214);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 34);
			this.ExitButton.TabIndex = 6;
			this.ExitButton.Text = "Exit [ESC]";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(197, 214);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 34);
			this.AddButton.TabIndex = 5;
			this.AddButton.Text = "Add [Enter]";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(48, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 30);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(22, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Surname:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(9, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "Telephone:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(48, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 30);
			this.label4.TabIndex = 5;
			this.label4.Text = "E-mail:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(36, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 30);
			this.label5.TabIndex = 6;
			this.label5.Text = "Cinema:";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.NameTextBox.Location = new System.Drawing.Point(128, 6);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(144, 35);
			this.NameTextBox.TabIndex = 0;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SurnameTextBox.Location = new System.Drawing.Point(128, 43);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(144, 35);
			this.SurnameTextBox.TabIndex = 1;
			// 
			// CinemasComboBox
			// 
			this.CinemasComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CinemasComboBox.FormattingEnabled = true;
			this.CinemasComboBox.Location = new System.Drawing.Point(128, 157);
			this.CinemasComboBox.Name = "CinemasComboBox";
			this.CinemasComboBox.Size = new System.Drawing.Size(144, 38);
			this.CinemasComboBox.TabIndex = 4;
			// 
			// TelephoneMaskedTextBox
			// 
			this.TelephoneMaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TelephoneMaskedTextBox.Location = new System.Drawing.Point(128, 81);
			this.TelephoneMaskedTextBox.Mask = "000000000";
			this.TelephoneMaskedTextBox.Name = "TelephoneMaskedTextBox";
			this.TelephoneMaskedTextBox.Size = new System.Drawing.Size(144, 35);
			this.TelephoneMaskedTextBox.TabIndex = 2;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.EmailTextBox.Location = new System.Drawing.Point(128, 119);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(144, 35);
			this.EmailTextBox.TabIndex = 3;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// AddNewEmployeeForm
			// 
			this.AcceptButton = this.AddButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ExitButton;
			this.ClientSize = new System.Drawing.Size(302, 256);
			this.ControlBox = false;
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.TelephoneMaskedTextBox);
			this.Controls.Add(this.CinemasComboBox);
			this.Controls.Add(this.SurnameTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.ExitButton);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddNewEmployeeForm";
			this.Text = "Add New Employee";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.AddNewEmployeeForm_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.ComboBox CinemasComboBox;
		private System.Windows.Forms.MaskedTextBox TelephoneMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox EmailTextBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}