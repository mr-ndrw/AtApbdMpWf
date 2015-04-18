namespace AtApbdMpWf.Forms
{
	partial class UpdateProjectionForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.ComboBoxRoom = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PickerDateTime = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.ButtonUpdate = new System.Windows.Forms.Button();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.MaskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(31, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 37);
			this.label2.TabIndex = 2;
			this.label2.Text = "Room:";
			// 
			// ComboBoxRoom
			// 
			this.ComboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxRoom.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ComboBoxRoom.FormattingEnabled = true;
			this.ComboBoxRoom.Location = new System.Drawing.Point(131, 4);
			this.ComboBoxRoom.Name = "ComboBoxRoom";
			this.ComboBoxRoom.Size = new System.Drawing.Size(188, 45);
			this.ComboBoxRoom.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(46, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 37);
			this.label3.TabIndex = 4;
			this.label3.Text = "Date:";
			// 
			// PickerDateTime
			// 
			this.PickerDateTime.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PickerDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PickerDateTime.Location = new System.Drawing.Point(131, 55);
			this.PickerDateTime.Name = "PickerDateTime";
			this.PickerDateTime.Size = new System.Drawing.Size(189, 29);
			this.PickerDateTime.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(20, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 37);
			this.label4.TabIndex = 6;
			this.label4.Text = "Length:";
			// 
			// ButtonUpdate
			// 
			this.ButtonUpdate.Location = new System.Drawing.Point(229, 144);
			this.ButtonUpdate.Name = "ButtonUpdate";
			this.ButtonUpdate.Size = new System.Drawing.Size(91, 38);
			this.ButtonUpdate.TabIndex = 8;
			this.ButtonUpdate.Text = "Update [Enter]";
			this.ButtonUpdate.UseVisualStyleBackColor = true;
			this.ButtonUpdate.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// ButtonExit
			// 
			this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonExit.Location = new System.Drawing.Point(12, 144);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(88, 38);
			this.ButtonExit.TabIndex = 9;
			this.ButtonExit.Text = "Exit [ESC]";
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			// 
			// MaskedTextBoxLength
			// 
			this.MaskedTextBoxLength.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.MaskedTextBoxLength.Location = new System.Drawing.Point(131, 90);
			this.MaskedTextBoxLength.Mask = "000";
			this.MaskedTextBoxLength.Name = "MaskedTextBoxLength";
			this.MaskedTextBoxLength.Size = new System.Drawing.Size(189, 43);
			this.MaskedTextBoxLength.TabIndex = 2;
			// 
			// UpdateProjectionForm
			// 
			this.AcceptButton = this.ButtonUpdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonExit;
			this.ClientSize = new System.Drawing.Size(332, 190);
			this.ControlBox = false;
			this.Controls.Add(this.MaskedTextBoxLength);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.ButtonUpdate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.PickerDateTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ComboBoxRoom);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "UpdateProjectionForm";
			this.Text = "Update a Projection";
			this.Load += new System.EventHandler(this.UpdateProjectionForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ComboBoxRoom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker PickerDateTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button ButtonUpdate;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.MaskedTextBox MaskedTextBoxLength;
	}
}