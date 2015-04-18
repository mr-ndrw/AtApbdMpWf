using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtApbdMpWf.BusinessLogic;
using AtApbdMpWf.Entity;

namespace AtApbdMpWf.Forms.EmployeeFormSubforms
{
	public partial class AddEmployeeToCinemaForm : Form
	{
		private CinemaService _cinemaService;
		private Employee _currentlyViewedEmployee;

		public AddEmployeeToCinemaForm(CinemaService cinemaService, Employee currentlyViewedEmployee)
		{
			_cinemaService = cinemaService;
			_currentlyViewedEmployee = currentlyViewedEmployee;

			InitializeComponent();
		}

		private void AddEmployeeToCinemaForm_Load(object sender, EventArgs e)
		{
			employeeNameSurnameLabel.Text = _currentlyViewedEmployee.NameSurname;
			CinemaComboBox.DataSource = _cinemaService.GetAllCinemas();
			CinemaComboBox.ValueMember = "Id";
			CinemaComboBox.DisplayMember = "Name";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selected = CinemaComboBox.SelectedItem as Cinema;
			RegionNameLabel.Text = _cinemaService.GetRegion(selected).Name;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			var selected = CinemaComboBox.SelectedItem as Cinema;

			_cinemaService.AddExsistingEmployeeToCinema(selected.Id, _currentlyViewedEmployee);

			Close();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
