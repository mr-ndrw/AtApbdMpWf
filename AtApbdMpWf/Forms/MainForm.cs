using System.Windows.Forms;
using AtApbdMpWf.BusinessLogic;
using AtApbdMpWf.Data;

namespace AtApbdMpWf.Forms
{
	public partial class MainForm : Form
	{
		private IApbdDataProvider _apbdDataProvider;
		private CinemaService _cinemaService;

		public MainForm(IApbdDataProvider apbdDataProvider)
		{
			_apbdDataProvider = apbdDataProvider;
			_cinemaService = new CinemaService(_apbdDataProvider);

			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			var cinemasSubForm = new CinemaForm(_cinemaService);
			cinemasSubForm.FormBorderStyle = FormBorderStyle.None;
			cinemasSubForm.TopLevel = false;
			cinemasSubForm.ShowInTaskbar = false;
			cinemasSubForm.Show();
			cinemasSubForm.Dock = DockStyle.Fill;
			
			tabPage1.Controls.Add(cinemasSubForm);


			var employeesSubForm = new EmployeeForm(_cinemaService);
			employeesSubForm.FormBorderStyle = FormBorderStyle.None;
			employeesSubForm.TopLevel = false;
			employeesSubForm.ShowInTaskbar = false;
			employeesSubForm.Show();
			employeesSubForm.Dock = DockStyle.Fill;

			EmployeesTabPage.Controls.Add(employeesSubForm);

			var regionManagementSubForm = new ManagementForm(_cinemaService);
			regionManagementSubForm.FormBorderStyle = FormBorderStyle.None;
			regionManagementSubForm.TopLevel = false;
			regionManagementSubForm.ShowInTaskbar = false;
			regionManagementSubForm.Show();
			regionManagementSubForm.Dock = DockStyle.Fill;

			RegionManagementTabPage.Controls.Add(regionManagementSubForm);

			ActiveControl = cinemasSubForm;
		}

		private void tabPage2_Click(object sender, System.EventArgs e)
		{
			ActiveControl = CinemaTabControl.GetControl(1);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
		
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control)
				ProcessControlKeyPressed(e);
			else if(e.Alt)
 				ProcessAltKeyPressed(e);
			else 
				ProcessBareKeyPressed(e);

		}

		private void ProcessControlKeyPressed(KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.D1:
				{
					CinemaTabControl.SelectTab(0);
					ActiveControl = CinemaTabControl.GetControl(0);
					tabPage1.Controls[0].Focus();
				
					break;
				}
				case Keys.D2:
				{
					CinemaTabControl.SelectTab(1);
					ActiveControl = CinemaTabControl.GetControl(1);
					EmployeesTabPage.Controls[0].Focus();
					break;
				}
				case Keys.D3:
				{
					CinemaTabControl.SelectTab(2);
					ActiveControl = CinemaTabControl.GetControl(2);
					RegionManagementTabPage.Controls[0].Focus();
					break;
				}
			}
		}

		private void ProcessAltKeyPressed(KeyEventArgs e)
		{
			
		}

		private void ProcessBareKeyPressed(KeyEventArgs e)
		{
			
		}

		private void CinemaTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}

		private void RegionManagementTabPage_Click(object sender, System.EventArgs e)
		{
			ActiveControl = CinemaTabControl.GetControl(2);
		}
	}
}
