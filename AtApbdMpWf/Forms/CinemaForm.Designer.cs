namespace AtApbdMpWf.Forms
{
	partial class CinemaForm
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
			this.CinemaSplitContainer = new System.Windows.Forms.SplitContainer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.ProjectionCalendar = new System.Windows.Forms.MonthCalendar();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.ProjectionsDataGridView = new System.Windows.Forms.DataGridView();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.ButtonAddProjection = new System.Windows.Forms.Button();
			this.ButtonUpdateProjection = new System.Windows.Forms.Button();
			this.ButtonDeleteProjection = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ShowingProjectionsLabel = new System.Windows.Forms.Label();
			this.ButtonShowFuturePredictions = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.EmployeesDgv = new System.Windows.Forms.DataGridView();
			this.panel9 = new System.Windows.Forms.Panel();
			this.LinkLabelChangeManager = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.LinkLabelManager = new System.Windows.Forms.LinkLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.LabelRegion = new System.Windows.Forms.Label();
			this.LabelTelephone = new System.Windows.Forms.Label();
			this.LabelAddress = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ComboBoxCinemas = new System.Windows.Forms.ComboBox();
			this.LabelCinemaName = new System.Windows.Forms.Label();
			this.RefreshButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.CinemaSplitContainer)).BeginInit();
			this.CinemaSplitContainer.Panel1.SuspendLayout();
			this.CinemaSplitContainer.Panel2.SuspendLayout();
			this.CinemaSplitContainer.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProjectionsDataGridView)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EmployeesDgv)).BeginInit();
			this.panel9.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// CinemaSplitContainer
			// 
			this.CinemaSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CinemaSplitContainer.Location = new System.Drawing.Point(0, 45);
			this.CinemaSplitContainer.Name = "CinemaSplitContainer";
			// 
			// CinemaSplitContainer.Panel1
			// 
			this.CinemaSplitContainer.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.CinemaSplitContainer.Panel1.Controls.Add(this.panel2);
			this.CinemaSplitContainer.Panel1.Controls.Add(this.panel1);
			// 
			// CinemaSplitContainer.Panel2
			// 
			this.CinemaSplitContainer.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.CinemaSplitContainer.Panel2.Controls.Add(this.groupBox3);
			this.CinemaSplitContainer.Panel2.Controls.Add(this.groupBox2);
			this.CinemaSplitContainer.Size = new System.Drawing.Size(1056, 861);
			this.CinemaSplitContainer.SplitterDistance = 513;
			this.CinemaSplitContainer.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel7);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(513, 516);
			this.panel2.TabIndex = 9;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.ProjectionCalendar);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 37);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(492, 479);
			this.panel7.TabIndex = 12;
			// 
			// ProjectionCalendar
			// 
			this.ProjectionCalendar.BackColor = System.Drawing.Color.Silver;
			this.ProjectionCalendar.CalendarDimensions = new System.Drawing.Size(3, 3);
			this.ProjectionCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProjectionCalendar.Location = new System.Drawing.Point(0, 0);
			this.ProjectionCalendar.Name = "ProjectionCalendar";
			this.ProjectionCalendar.TabIndex = 1;
			this.ProjectionCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(492, 37);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(21, 479);
			this.panel6.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(302, 37);
			this.label3.TabIndex = 5;
			this.label3.Text = "Upcoming Projections";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 516);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(513, 345);
			this.panel1.TabIndex = 8;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.ProjectionsDataGridView);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 41);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(513, 304);
			this.panel4.TabIndex = 9;
			// 
			// ProjectionsDataGridView
			// 
			this.ProjectionsDataGridView.AllowUserToAddRows = false;
			this.ProjectionsDataGridView.AllowUserToDeleteRows = false;
			this.ProjectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProjectionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProjectionsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.ProjectionsDataGridView.Name = "ProjectionsDataGridView";
			this.ProjectionsDataGridView.ReadOnly = true;
			this.ProjectionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ProjectionsDataGridView.Size = new System.Drawing.Size(513, 257);
			this.ProjectionsDataGridView.TabIndex = 3;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Controls.Add(this.ButtonUpdateProjection);
			this.panel5.Controls.Add(this.ButtonDeleteProjection);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 257);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(513, 47);
			this.panel5.TabIndex = 0;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.ButtonAddProjection);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(165, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(215, 47);
			this.panel8.TabIndex = 11;
			// 
			// ButtonAddProjection
			// 
			this.ButtonAddProjection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonAddProjection.Location = new System.Drawing.Point(0, 0);
			this.ButtonAddProjection.Name = "ButtonAddProjection";
			this.ButtonAddProjection.Size = new System.Drawing.Size(215, 47);
			this.ButtonAddProjection.TabIndex = 5;
			this.ButtonAddProjection.Text = "Add Projection [A]";
			this.ButtonAddProjection.UseVisualStyleBackColor = true;
			this.ButtonAddProjection.Click += new System.EventHandler(this.ButtonAddProjection_Click);
			// 
			// ButtonUpdateProjection
			// 
			this.ButtonUpdateProjection.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonUpdateProjection.Location = new System.Drawing.Point(380, 0);
			this.ButtonUpdateProjection.Name = "ButtonUpdateProjection";
			this.ButtonUpdateProjection.Size = new System.Drawing.Size(133, 47);
			this.ButtonUpdateProjection.TabIndex = 6;
			this.ButtonUpdateProjection.Text = "Update Projection [Z]";
			this.ButtonUpdateProjection.UseVisualStyleBackColor = true;
			this.ButtonUpdateProjection.Click += new System.EventHandler(this.ButtonUpdateProjection_Click);
			// 
			// ButtonDeleteProjection
			// 
			this.ButtonDeleteProjection.BackColor = System.Drawing.Color.Maroon;
			this.ButtonDeleteProjection.Dock = System.Windows.Forms.DockStyle.Left;
			this.ButtonDeleteProjection.Location = new System.Drawing.Point(0, 0);
			this.ButtonDeleteProjection.Name = "ButtonDeleteProjection";
			this.ButtonDeleteProjection.Size = new System.Drawing.Size(165, 47);
			this.ButtonDeleteProjection.TabIndex = 4;
			this.ButtonDeleteProjection.Text = "Delete Projection [D]";
			this.ButtonDeleteProjection.UseVisualStyleBackColor = false;
			this.ButtonDeleteProjection.Click += new System.EventHandler(this.ButtonDeleteProjection_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.ShowingProjectionsLabel);
			this.panel3.Controls.Add(this.ButtonShowFuturePredictions);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(513, 41);
			this.panel3.TabIndex = 8;
			// 
			// ShowingProjectionsLabel
			// 
			this.ShowingProjectionsLabel.AutoSize = true;
			this.ShowingProjectionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ShowingProjectionsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ShowingProjectionsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ShowingProjectionsLabel.Location = new System.Drawing.Point(165, 0);
			this.ShowingProjectionsLabel.Name = "ShowingProjectionsLabel";
			this.ShowingProjectionsLabel.Size = new System.Drawing.Size(0, 30);
			this.ShowingProjectionsLabel.TabIndex = 8;
			this.ShowingProjectionsLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.ShowingProjectionsLabel.Click += new System.EventHandler(this.ShowingProjectionsLabel_Click);
			// 
			// ButtonShowFuturePredictions
			// 
			this.ButtonShowFuturePredictions.Dock = System.Windows.Forms.DockStyle.Left;
			this.ButtonShowFuturePredictions.Location = new System.Drawing.Point(0, 0);
			this.ButtonShowFuturePredictions.Name = "ButtonShowFuturePredictions";
			this.ButtonShowFuturePredictions.Size = new System.Drawing.Size(165, 41);
			this.ButtonShowFuturePredictions.TabIndex = 2;
			this.ButtonShowFuturePredictions.Text = "Show Future Projections [F]";
			this.ButtonShowFuturePredictions.UseVisualStyleBackColor = true;
			this.ButtonShowFuturePredictions.Click += new System.EventHandler(this.ButtonShowFuturePredictions_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panel10);
			this.groupBox3.Controls.Add(this.panel9);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(539, 686);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Employees";
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.panel11);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(3, 99);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(533, 584);
			this.panel10.TabIndex = 2;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.EmployeesDgv);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(533, 584);
			this.panel11.TabIndex = 0;
			// 
			// EmployeesDgv
			// 
			this.EmployeesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EmployeesDgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EmployeesDgv.GridColor = System.Drawing.SystemColors.Control;
			this.EmployeesDgv.Location = new System.Drawing.Point(0, 0);
			this.EmployeesDgv.Name = "EmployeesDgv";
			this.EmployeesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.EmployeesDgv.Size = new System.Drawing.Size(533, 584);
			this.EmployeesDgv.TabIndex = 0;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.LinkLabelChangeManager);
			this.panel9.Controls.Add(this.label4);
			this.panel9.Controls.Add(this.LinkLabelManager);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel9.Location = new System.Drawing.Point(3, 39);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(533, 60);
			this.panel9.TabIndex = 2;
			// 
			// LinkLabelChangeManager
			// 
			this.LinkLabelChangeManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LinkLabelChangeManager.AutoSize = true;
			this.LinkLabelChangeManager.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LinkLabelChangeManager.LinkColor = System.Drawing.Color.OrangeRed;
			this.LinkLabelChangeManager.Location = new System.Drawing.Point(385, 27);
			this.LinkLabelChangeManager.Name = "LinkLabelChangeManager";
			this.LinkLabelChangeManager.Size = new System.Drawing.Size(139, 17);
			this.LinkLabelChangeManager.TabIndex = 7;
			this.LinkLabelChangeManager.TabStop = true;
			this.LinkLabelChangeManager.Text = "Change Manager [M]";
			this.LinkLabelChangeManager.VisitedLinkColor = System.Drawing.Color.OrangeRed;
			this.LinkLabelChangeManager.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelChangeManager_LinkClicked);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(3, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "Manager:";
			// 
			// LinkLabelManager
			// 
			this.LinkLabelManager.AutoSize = true;
			this.LinkLabelManager.Font = new System.Drawing.Font("Segoe UI", 14.25F);
			this.LinkLabelManager.LinkColor = System.Drawing.Color.Black;
			this.LinkLabelManager.Location = new System.Drawing.Point(101, 21);
			this.LinkLabelManager.Name = "LinkLabelManager";
			this.LinkLabelManager.Size = new System.Drawing.Size(212, 25);
			this.LinkLabelManager.TabIndex = 1;
			this.LinkLabelManager.TabStop = true;
			this.LinkLabelManager.Text = "Cinema Manager Name";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.LabelRegion);
			this.groupBox2.Controls.Add(this.LabelTelephone);
			this.groupBox2.Controls.Add(this.LabelAddress);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.groupBox2.Location = new System.Drawing.Point(0, 686);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(539, 175);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Contact";
			// 
			// LabelRegion
			// 
			this.LabelRegion.AutoSize = true;
			this.LabelRegion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelRegion.Location = new System.Drawing.Point(184, 125);
			this.LabelRegion.Name = "LabelRegion";
			this.LabelRegion.Size = new System.Drawing.Size(140, 25);
			this.LabelRegion.TabIndex = 7;
			this.LabelRegion.Text = "Cinema Region";
			// 
			// LabelTelephone
			// 
			this.LabelTelephone.AutoSize = true;
			this.LabelTelephone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelTelephone.Location = new System.Drawing.Point(183, 91);
			this.LabelTelephone.Name = "LabelTelephone";
			this.LabelTelephone.Size = new System.Drawing.Size(170, 25);
			this.LabelTelephone.TabIndex = 6;
			this.LabelTelephone.Text = "Cinema Telephone";
			// 
			// LabelAddress
			// 
			this.LabelAddress.AutoSize = true;
			this.LabelAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelAddress.Location = new System.Drawing.Point(183, 52);
			this.LabelAddress.Name = "LabelAddress";
			this.LabelAddress.Size = new System.Drawing.Size(148, 25);
			this.LabelAddress.TabIndex = 5;
			this.LabelAddress.Text = "Cinema Address";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(108, 125);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 25);
			this.label7.TabIndex = 4;
			this.label7.Text = "Region:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(3, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(181, 25);
			this.label6.TabIndex = 3;
			this.label6.Text = "Telephone Number:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(99, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 25);
			this.label5.TabIndex = 2;
			this.label5.Text = "Address:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 45);
			this.label1.TabIndex = 1;
			this.label1.Text = "MANAGE CINEMAS";
			// 
			// ComboBoxCinemas
			// 
			this.ComboBoxCinemas.BackColor = System.Drawing.Color.Gainsboro;
			this.ComboBoxCinemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxCinemas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ComboBoxCinemas.FormattingEnabled = true;
			this.ComboBoxCinemas.Location = new System.Drawing.Point(308, 2);
			this.ComboBoxCinemas.Name = "ComboBoxCinemas";
			this.ComboBoxCinemas.Size = new System.Drawing.Size(178, 29);
			this.ComboBoxCinemas.TabIndex = 0;
			this.ComboBoxCinemas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCinemas_SelectedIndexChanged);
			// 
			// LabelCinemaName
			// 
			this.LabelCinemaName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelCinemaName.AutoSize = true;
			this.LabelCinemaName.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelCinemaName.ForeColor = System.Drawing.Color.Gray;
			this.LabelCinemaName.Location = new System.Drawing.Point(854, 2);
			this.LabelCinemaName.Name = "LabelCinemaName";
			this.LabelCinemaName.Size = new System.Drawing.Size(202, 40);
			this.LabelCinemaName.TabIndex = 4;
			this.LabelCinemaName.Text = "Cinema Name";
			this.LabelCinemaName.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// RefreshButton
			// 
			this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RefreshButton.Location = new System.Drawing.Point(492, 0);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(108, 27);
			this.RefreshButton.TabIndex = 5;
			this.RefreshButton.Text = "Refresh [F5]";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// CinemaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1056, 906);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.LabelCinemaName);
			this.Controls.Add(this.ComboBoxCinemas);
			this.Controls.Add(this.CinemaSplitContainer);
			this.Controls.Add(this.label1);
			this.KeyPreview = true;
			this.Name = "CinemaForm";
			this.Text = "Cinema Managment Tab";
			this.Activated += new System.EventHandler(this.CinemaForm_Enter);
			this.Load += new System.EventHandler(this.CinemaForm_Load);
			this.Enter += new System.EventHandler(this.CinemaForm_Enter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CinemaForm_KeyDown);
			this.CinemaSplitContainer.Panel1.ResumeLayout(false);
			this.CinemaSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CinemaSplitContainer)).EndInit();
			this.CinemaSplitContainer.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ProjectionsDataGridView)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.EmployeesDgv)).EndInit();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer CinemaSplitContainer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MonthCalendar ProjectionCalendar;
		private System.Windows.Forms.DataGridView ProjectionsDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button ButtonShowFuturePredictions;
		private System.Windows.Forms.Button ButtonUpdateProjection;
		private System.Windows.Forms.Button ButtonAddProjection;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label ShowingProjectionsLabel;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button ButtonDeleteProjection;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel LinkLabelManager;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.DataGridView EmployeesDgv;
		private System.Windows.Forms.LinkLabel LinkLabelChangeManager;
		private System.Windows.Forms.Label LabelRegion;
		private System.Windows.Forms.Label LabelTelephone;
		private System.Windows.Forms.Label LabelAddress;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ComboBoxCinemas;
		private System.Windows.Forms.Label LabelCinemaName;
		private System.Windows.Forms.Button RefreshButton;

	}
}