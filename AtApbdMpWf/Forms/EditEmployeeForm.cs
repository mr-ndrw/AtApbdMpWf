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
	public partial class EditEmployeeForm : Form
	{
		private CinemaService _cinemaService;
		private Employee _employeeToUpdate;

		public EditEmployeeForm(CinemaService cinemaService, Employee employeeToUpdate)
		{
			_cinemaService = cinemaService;
			_employeeToUpdate = employeeToUpdate;
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

			var employee = new Employee { Id=_employeeToUpdate.Id, Name = NameTextBox.Text, Surname = SurnameTextBox.Text, TelephoneNo = TelephoneMaskedTextBox.Text, Email = EmailTextBox.Text };

			_cinemaService.UpdateEmployee(employee);

			Close();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
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

		private void EditEmployeeForm_Load(object sender, EventArgs e)
		{
			NameTextBox.Text = _employeeToUpdate.Name;
			SurnameTextBox.Text = _employeeToUpdate.Surname;
			TelephoneMaskedTextBox.Text = _employeeToUpdate.TelephoneNo;
			EmailTextBox.Text = _employeeToUpdate.Email;
		}

	}
}
