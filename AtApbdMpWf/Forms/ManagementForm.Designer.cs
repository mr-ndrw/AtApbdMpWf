namespace AtApbdMpWf.Forms
{
	partial class ManagementForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.RegionNameLabel = new System.Windows.Forms.Label();
			this.CinemaDataGridView = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.NextRegionButton = new System.Windows.Forms.Button();
			this.PrevRegionButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.CinemaAddressLabel = new System.Windows.Forms.Label();
			this.CinemaNameLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.NextCinemaButton = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.PreviousCinemaButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CinemaDataGridView)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1081, 798);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Controls.Add(this.RegionNameLabel);
			this.panel3.Controls.Add(this.CinemaDataGridView);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.button3);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.NextRegionButton);
			this.panel3.Controls.Add(this.PrevRegionButton);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(12, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1057, 361);
			this.panel3.TabIndex = 0;
			// 
			// RegionNameLabel
			// 
			this.RegionNameLabel.AutoSize = true;
			this.RegionNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RegionNameLabel.Location = new System.Drawing.Point(130, 65);
			this.RegionNameLabel.Name = "RegionNameLabel";
			this.RegionNameLabel.Size = new System.Drawing.Size(94, 37);
			this.RegionNameLabel.TabIndex = 18;
			this.RegionNameLabel.Text = "Name:";
			// 
			// CinemaDataGridView
			// 
			this.CinemaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.CinemaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CinemaDataGridView.Location = new System.Drawing.Point(474, 50);
			this.CinemaDataGridView.Name = "CinemaDataGridView";
			this.CinemaDataGridView.Size = new System.Drawing.Size(563, 299);
			this.CinemaDataGridView.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(467, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(254, 37);
			this.label5.TabIndex = 16;
			this.label5.Text = "Contained Cinemas:";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button3.Location = new System.Drawing.Point(11, 262);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(148, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "Delete Region [Q]";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(11, 222);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "Edit Region [W]";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(11, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(148, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Add New Region [E]";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// NextRegionButton
			// 
			this.NextRegionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.NextRegionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.NextRegionButton.Location = new System.Drawing.Point(111, 315);
			this.NextRegionButton.Name = "NextRegionButton";
			this.NextRegionButton.Size = new System.Drawing.Size(94, 34);
			this.NextRegionButton.TabIndex = 4;
			this.NextRegionButton.Text = "Next [X]";
			this.NextRegionButton.UseVisualStyleBackColor = true;
			this.NextRegionButton.Click += new System.EventHandler(this.NextRegionButton_Click_1);
			// 
			// PrevRegionButton
			// 
			this.PrevRegionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.PrevRegionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PrevRegionButton.Location = new System.Drawing.Point(11, 315);
			this.PrevRegionButton.Name = "PrevRegionButton";
			this.PrevRegionButton.Size = new System.Drawing.Size(94, 34);
			this.PrevRegionButton.TabIndex = 3;
			this.PrevRegionButton.Text = "Previous [Z]";
			this.PrevRegionButton.UseVisualStyleBackColor = true;
			this.PrevRegionButton.Click += new System.EventHandler(this.PrevRegionButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(30, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 37);
			this.label3.TabIndex = 10;
			this.label3.Text = "Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(7, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 65);
			this.label1.TabIndex = 9;
			this.label1.Text = "Region";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 379);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1081, 419);
			this.panel2.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Control;
			this.panel4.Controls.Add(this.CinemaAddressLabel);
			this.panel4.Controls.Add(this.CinemaNameLabel);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.button4);
			this.panel4.Controls.Add(this.NextCinemaButton);
			this.panel4.Controls.Add(this.button5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.button6);
			this.panel4.Controls.Add(this.PreviousCinemaButton);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new System.Drawing.Point(12, 13);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1057, 394);
			this.panel4.TabIndex = 0;
			// 
			// CinemaAddressLabel
			// 
			this.CinemaAddressLabel.AutoSize = true;
			this.CinemaAddressLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CinemaAddressLabel.Location = new System.Drawing.Point(130, 102);
			this.CinemaAddressLabel.Name = "CinemaAddressLabel";
			this.CinemaAddressLabel.Size = new System.Drawing.Size(94, 37);
			this.CinemaAddressLabel.TabIndex = 23;
			this.CinemaAddressLabel.Text = "Name:";
			// 
			// CinemaNameLabel
			// 
			this.CinemaNameLabel.AutoSize = true;
			this.CinemaNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CinemaNameLabel.Location = new System.Drawing.Point(130, 65);
			this.CinemaNameLabel.Name = "CinemaNameLabel";
			this.CinemaNameLabel.Size = new System.Drawing.Size(94, 37);
			this.CinemaNameLabel.TabIndex = 22;
			this.CinemaNameLabel.Text = "Name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(7, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(117, 37);
			this.label6.TabIndex = 21;
			this.label6.Text = "Address:";
			// 
			// button4
			// 
			this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button4.Location = new System.Drawing.Point(11, 254);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(148, 34);
			this.button4.TabIndex = 7;
			this.button4.Text = "Delete Cinema [D]";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// NextCinemaButton
			// 
			this.NextCinemaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.NextCinemaButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.NextCinemaButton.Location = new System.Drawing.Point(111, 344);
			this.NextCinemaButton.Name = "NextCinemaButton";
			this.NextCinemaButton.Size = new System.Drawing.Size(94, 36);
			this.NextCinemaButton.TabIndex = 9;
			this.NextCinemaButton.Text = "Next [V]";
			this.NextCinemaButton.UseVisualStyleBackColor = true;
			this.NextCinemaButton.Click += new System.EventHandler(this.NextCinemaButton_Click);
			// 
			// button5
			// 
			this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button5.Location = new System.Drawing.Point(11, 214);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(148, 34);
			this.button5.TabIndex = 6;
			this.button5.Text = "Edit Cinema [S]";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(30, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 37);
			this.label4.TabIndex = 7;
			this.label4.Text = "Name:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// button6
			// 
			this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button6.Location = new System.Drawing.Point(11, 174);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(148, 34);
			this.button6.TabIndex = 5;
			this.button6.Text = "Add New Cinema [A]";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click_1);
			// 
			// PreviousCinemaButton
			// 
			this.PreviousCinemaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.PreviousCinemaButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PreviousCinemaButton.Location = new System.Drawing.Point(11, 344);
			this.PreviousCinemaButton.Name = "PreviousCinemaButton";
			this.PreviousCinemaButton.Size = new System.Drawing.Size(94, 36);
			this.PreviousCinemaButton.TabIndex = 8;
			this.PreviousCinemaButton.Text = "Previous [C]";
			this.PreviousCinemaButton.UseVisualStyleBackColor = true;
			this.PreviousCinemaButton.Click += new System.EventHandler(this.PreviousCinemaButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 65);
			this.label2.TabIndex = 6;
			this.label2.Text = "Cinema";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// ManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1081, 798);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "ManagementForm";
			this.Text = "ManagementForm";
			this.Load += new System.EventHandler(this.ManagementForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManagementForm_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CinemaDataGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button NextRegionButton;
		private System.Windows.Forms.Button PrevRegionButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView CinemaDataGridView;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button NextCinemaButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button PreviousCinemaButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label RegionNameLabel;
		private System.Windows.Forms.Label CinemaAddressLabel;
		private System.Windows.Forms.Label CinemaNameLabel;

	}
}