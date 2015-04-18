using System.Windows.Forms;

namespace AtApbdMpWf.Forms
{
	partial class MainForm
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
			this.CinemaTabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.EmployeesTabPage = new System.Windows.Forms.TabPage();
			this.RegionManagementTabPage = new System.Windows.Forms.TabPage();
			this.CinemaTabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// CinemaTabControl
			// 
			this.CinemaTabControl.Controls.Add(this.tabPage1);
			this.CinemaTabControl.Controls.Add(this.EmployeesTabPage);
			this.CinemaTabControl.Controls.Add(this.RegionManagementTabPage);
			this.CinemaTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CinemaTabControl.Location = new System.Drawing.Point(0, 0);
			this.CinemaTabControl.Name = "CinemaTabControl";
			this.CinemaTabControl.SelectedIndex = 0;
			this.CinemaTabControl.Size = new System.Drawing.Size(1084, 961);
			this.CinemaTabControl.TabIndex = 0;
			this.CinemaTabControl.SelectedIndexChanged += new System.EventHandler(this.CinemaTabControl_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1076, 935);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Mange Cinema [Ctrl-1]";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// EmployeesTabPage
			// 
			this.EmployeesTabPage.Location = new System.Drawing.Point(4, 22);
			this.EmployeesTabPage.Name = "EmployeesTabPage";
			this.EmployeesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.EmployeesTabPage.Size = new System.Drawing.Size(1076, 935);
			this.EmployeesTabPage.TabIndex = 1;
			this.EmployeesTabPage.Text = "Manage Employees [Ctrl-2]";
			this.EmployeesTabPage.UseVisualStyleBackColor = true;
			this.EmployeesTabPage.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// RegionManagementTabPage
			// 
			this.RegionManagementTabPage.Location = new System.Drawing.Point(4, 22);
			this.RegionManagementTabPage.Name = "RegionManagementTabPage";
			this.RegionManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.RegionManagementTabPage.Size = new System.Drawing.Size(1076, 935);
			this.RegionManagementTabPage.TabIndex = 2;
			this.RegionManagementTabPage.Text = "Cinema & Region Management [Ctrl-3]";
			this.RegionManagementTabPage.UseVisualStyleBackColor = true;
			this.RegionManagementTabPage.Click += new System.EventHandler(this.RegionManagementTabPage_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 961);
			this.Controls.Add(this.CinemaTabControl);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(1000, 800);
			this.Name = "MainForm";
			this.Text = "Cinema Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.CinemaTabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		#region Helper

		private static Form BuildSubForm(Form form)
		{
			form.FormBorderStyle = FormBorderStyle.None;
			form.TopLevel = false;
			form.ShowInTaskbar = false;
			form.Show();
			form.Dock = DockStyle.Fill;
			form.Location = new System.Drawing.Point(0, 0);
			return form;
		}

		#endregion


		private System.Windows.Forms.TabControl CinemaTabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage EmployeesTabPage;
		private TabPage RegionManagementTabPage;

	}
}

