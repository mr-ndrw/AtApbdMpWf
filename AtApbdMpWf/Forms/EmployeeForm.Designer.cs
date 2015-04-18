namespace AtApbdMpWf.Forms
{
	partial class EmployeeForm
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
			this.RegionCinemaTreeView = new System.Windows.Forms.TreeView();
			this.FormPanel = new System.Windows.Forms.Panel();
			this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
			this.TotalNumberOfEmployeesLabel = new System.Windows.Forms.Label();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.AddNewEmpButton = new System.Windows.Forms.Button();
			this.AddEmpToCinemaButton = new System.Windows.Forms.Button();
			this.EditEmpButton = new System.Windows.Forms.Button();
			this.DeleteEmpButton = new System.Windows.Forms.Button();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.FormPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// RegionCinemaTreeView
			// 
			this.RegionCinemaTreeView.Dock = System.Windows.Forms.DockStyle.Left;
			this.RegionCinemaTreeView.Location = new System.Drawing.Point(0, 0);
			this.RegionCinemaTreeView.Name = "RegionCinemaTreeView";
			this.RegionCinemaTreeView.Size = new System.Drawing.Size(213, 663);
			this.RegionCinemaTreeView.TabIndex = 0;
			this.RegionCinemaTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RegionCinemaTreeView_AfterSelect);
			// 
			// FormPanel
			// 
			this.FormPanel.Controls.Add(this.EmployeesDataGridView);
			this.FormPanel.Controls.Add(this.TotalNumberOfEmployeesLabel);
			this.FormPanel.Controls.Add(this.ButtonPanel);
			this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FormPanel.Location = new System.Drawing.Point(213, 0);
			this.FormPanel.Name = "FormPanel";
			this.FormPanel.Size = new System.Drawing.Size(669, 663);
			this.FormPanel.TabIndex = 1;
			// 
			// EmployeesDataGridView
			// 
			this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EmployeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EmployeesDataGridView.Location = new System.Drawing.Point(0, 0);
			this.EmployeesDataGridView.MultiSelect = false;
			this.EmployeesDataGridView.Name = "EmployeesDataGridView";
			this.EmployeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.EmployeesDataGridView.Size = new System.Drawing.Size(669, 583);
			this.EmployeesDataGridView.TabIndex = 2;
			// 
			// TotalNumberOfEmployeesLabel
			// 
			this.TotalNumberOfEmployeesLabel.AutoSize = true;
			this.TotalNumberOfEmployeesLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.TotalNumberOfEmployeesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TotalNumberOfEmployeesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TotalNumberOfEmployeesLabel.Location = new System.Drawing.Point(0, 583);
			this.TotalNumberOfEmployeesLabel.Name = "TotalNumberOfEmployeesLabel";
			this.TotalNumberOfEmployeesLabel.Size = new System.Drawing.Size(0, 21);
			this.TotalNumberOfEmployeesLabel.TabIndex = 1;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.Controls.Add(this.AddNewEmpButton);
			this.ButtonPanel.Controls.Add(this.AddEmpToCinemaButton);
			this.ButtonPanel.Controls.Add(this.EditEmpButton);
			this.ButtonPanel.Controls.Add(this.DeleteEmpButton);
			this.ButtonPanel.Controls.Add(this.RefreshButton);
			this.ButtonPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonPanel.Location = new System.Drawing.Point(0, 604);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ButtonPanel.Size = new System.Drawing.Size(669, 59);
			this.ButtonPanel.TabIndex = 0;
			// 
			// AddNewEmpButton
			// 
			this.AddNewEmpButton.Location = new System.Drawing.Point(537, 3);
			this.AddNewEmpButton.Name = "AddNewEmpButton";
			this.AddNewEmpButton.Size = new System.Drawing.Size(129, 23);
			this.AddNewEmpButton.TabIndex = 3;
			this.AddNewEmpButton.Text = "Add New Employee [V]";
			this.AddNewEmpButton.UseVisualStyleBackColor = true;
			this.AddNewEmpButton.Click += new System.EventHandler(this.AddNewEmpButton_Click);
			// 
			// AddEmpToCinemaButton
			// 
			this.AddEmpToCinemaButton.Location = new System.Drawing.Point(375, 3);
			this.AddEmpToCinemaButton.Name = "AddEmpToCinemaButton";
			this.AddEmpToCinemaButton.Size = new System.Drawing.Size(156, 23);
			this.AddEmpToCinemaButton.TabIndex = 0;
			this.AddEmpToCinemaButton.Text = "Add Employee To Cinema [C]";
			this.AddEmpToCinemaButton.UseVisualStyleBackColor = true;
			this.AddEmpToCinemaButton.Click += new System.EventHandler(this.AddEmpToCinemaButton_Click);
			// 
			// EditEmpButton
			// 
			this.EditEmpButton.Location = new System.Drawing.Point(258, 3);
			this.EditEmpButton.Name = "EditEmpButton";
			this.EditEmpButton.Size = new System.Drawing.Size(111, 23);
			this.EditEmpButton.TabIndex = 1;
			this.EditEmpButton.Text = "Edit Employee [X]";
			this.EditEmpButton.UseVisualStyleBackColor = true;
			this.EditEmpButton.Click += new System.EventHandler(this.EditEmpButton_Click);
			// 
			// DeleteEmpButton
			// 
			this.DeleteEmpButton.Location = new System.Drawing.Point(133, 3);
			this.DeleteEmpButton.Name = "DeleteEmpButton";
			this.DeleteEmpButton.Size = new System.Drawing.Size(119, 23);
			this.DeleteEmpButton.TabIndex = 2;
			this.DeleteEmpButton.Text = "Delete Employee [Z]";
			this.DeleteEmpButton.UseVisualStyleBackColor = true;
			this.DeleteEmpButton.Click += new System.EventHandler(this.DeleteEmpButton_Click);
			// 
			// RefreshButton
			// 
			this.RefreshButton.Location = new System.Drawing.Point(25, 3);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(102, 23);
			this.RefreshButton.TabIndex = 2;
			this.RefreshButton.Text = "Refresh [F5]";
			this.RefreshButton.UseVisualStyleBackColor = false;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 663);
			this.Controls.Add(this.FormPanel);
			this.Controls.Add(this.RegionCinemaTreeView);
			this.KeyPreview = true;
			this.Name = "EmployeeForm";
			this.ShowIcon = false;
			this.Text = "EmployeeForm";
			this.Load += new System.EventHandler(this.EmployeeForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeForm_KeyDown);
			this.FormPanel.ResumeLayout(false);
			this.FormPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
			this.ButtonPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView RegionCinemaTreeView;
		private System.Windows.Forms.Panel FormPanel;
		private System.Windows.Forms.DataGridView EmployeesDataGridView;
		private System.Windows.Forms.Label TotalNumberOfEmployeesLabel;
		private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
		private System.Windows.Forms.Button AddEmpToCinemaButton;
		private System.Windows.Forms.Button EditEmpButton;
		private System.Windows.Forms.Button DeleteEmpButton;
		private System.Windows.Forms.Button AddNewEmpButton;
		private System.Windows.Forms.Button RefreshButton;
	}
}