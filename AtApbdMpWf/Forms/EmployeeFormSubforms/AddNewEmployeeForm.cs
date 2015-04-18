using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtApbdMpWf.BusinessLogic;
using AtApbdMpWf.Entity;

namespace AtApbdMpWf.Forms.EmployeeFormSubforms
{
	public partial class AddNewEmployeeForm : Form
	{
		private CinemaService _cinemaService;
		private EmployeeForm _parentForm;

		public AddNewEmployeeForm(CinemaService cinemaService, EmployeeForm parentForm)
		{
			_cinemaService = cinemaService;
			_parentForm = parentForm;
			InitializeComponent();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var validationMessages = ValidateControlsAnReturnMessage();

			if (validationMessages.Count != 0)
			{
				var messageBoxMessage = validationMessages.Aggregate("", (current, message) => current + (message + "\n"));

				MessageBox.Show(messageBoxMessage, "Error!", MessageBoxButtons.OK);
				return;
			}

			var idCinema = (int) CinemasComboBox.SelectedValue;
			var employee = new Employee {Name=NameTextBox.Text, Surname=SurnameTextBox.Text, TelephoneNo = TelephoneMaskedTextBox.Text, Email = EmailTextBox.Text};

			_cinemaService.AddEmployeeToCinema(idCinema, employee);

			Close();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddNewEmployeeForm_Load_1(object sender, EventArgs e)
		{
			CinemasComboBox.DataSource = _cinemaService.GetAllCinemas();
			CinemasComboBox.ValueMember = "Id";
			CinemasComboBox.DisplayMember = "Name";
		}

		private List<string> ValidateControlsAnReturnMessage()
		{
			var result = new List<string>();

			if (string.IsNullOrWhiteSpace(NameTextBox.Text))
			{
				result.Add("- You must provide a name!");
			}
			if (string.IsNullOrWhiteSpace(SurnameTextBox.Text))
			{
				result.Add("- You must provide a surname!");
			}
			const string emailRegExPattern = @"[\w-]+@([\w-]+\.)+[\w-]+";

			if (!Regex.IsMatch(EmailTextBox.Text, emailRegExPattern))
			{
				result.Add("- Please provide a valid email address!");
			}

			return result;
		}

	}
}
