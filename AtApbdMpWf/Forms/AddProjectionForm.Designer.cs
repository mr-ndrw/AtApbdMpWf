namespace AtApbdMpWf.Forms
{
	partial class AddProjectionForm
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
			this.LabelCurrentlyViewedCinemaName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ComboBoxRoom = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PickerDateTime = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.MaskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(13, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cinema:";
			// 
			// LabelCurrentlyViewedCinemaName
			// 
			this.LabelCurrentlyViewedCinemaName.AutoSize = true;
			this.LabelCurrentlyViewedCinemaName.BackColor = System.Drawing.SystemColors.Control;
			this.LabelCurrentlyViewedCinemaName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelCurrentlyViewedCinemaName.Location = new System.Drawing.Point(132, 6);
			this.LabelCurrentlyViewedCinemaName.Name = "LabelCurrentlyViewedCinemaName";
			this.LabelCurrentlyViewedCinemaName.Size = new System.Drawing.Size(102, 37);
			this.LabelCurrentlyViewedCinemaName.TabIndex = 1;
			this.LabelCurrentlyViewedCinemaName.Text = "cinema";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(32, 49);
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
			this.ComboBoxRoom.Location = new System.Drawing.Point(132, 46);
			this.ComboBoxRoom.Name = "ComboBoxRoom";
			this.ComboBoxRoom.Size = new System.Drawing.Size(188, 45);
			this.ComboBoxRoom.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(47, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 37);
			this.label3.TabIndex = 4;
			this.label3.Text = "Date:";
			// 
			// PickerDateTime
			// 
			this.PickerDateTime.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PickerDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PickerDateTime.Location = new System.Drawing.Point(132, 97);
			this.PickerDateTime.Name = "PickerDateTime";
			this.PickerDateTime.Size = new System.Drawing.Size(189, 29);
			this.PickerDateTime.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(21, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 37);
			this.label4.TabIndex = 6;
			this.label4.Text = "Length:";
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Location = new System.Drawing.Point(230, 186);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(91, 38);
			this.ButtonAdd.TabIndex = 8;
			this.ButtonAdd.Text = "Add [Enter]";
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// ButtonExit
			// 
			this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonExit.Location = new System.Drawing.Point(13, 186);
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
			this.MaskedTextBoxLength.Location = new System.Drawing.Point(132, 132);
			this.MaskedTextBoxLength.Mask = "000";
			this.MaskedTextBoxLength.Name = "MaskedTextBoxLength";
			this.MaskedTextBoxLength.Size = new System.Drawing.Size(189, 43);
			this.MaskedTextBoxLength.TabIndex = 3;
			this.MaskedTextBoxLength.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBoxLength_MaskInputRejected);
			this.MaskedTextBoxLength.TextChanged += new System.EventHandler(this.MaskedTextBoxLength_TextChanged);
			// 
			// AddProjectionForm
			// 
			this.AcceptButton = this.ButtonAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonExit;
			this.ClientSize = new System.Drawing.Size(332, 231);
			this.ControlBox = false;
			this.Controls.Add(this.MaskedTextBoxLength);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.ButtonAdd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.PickerDateTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ComboBoxRoom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LabelCurrentlyViewedCinemaName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AddProjectionForm";
			this.Text = "Add a Projection";
			this.Load += new System.EventHandler(this.AddProjectionForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LabelCurrentlyViewedCinemaName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ComboBoxRoom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker PickerDateTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button ButtonAdd;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.MaskedTextBox MaskedTextBoxLength;
	}
}