using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtApbdMpWf.BusinessLogic;
using AtApbdMpWf.Entity;

namespace AtApbdMpWf.Forms.ManagementFormSubForms.RegionSubForms
{
	public partial class AddCinemaSubForm
	{
		private CinemaService _cinemaService;
		private readonly ManagementForm _parentForm;

		public AddCinemaSubForm(CinemaService cinemaService, ManagementForm parentForm)
		{
			_cinemaService = cinemaService;
			_parentForm = parentForm;
			InitializeComponent();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var validationMessages = ValidateForm();

			if (validationMessages.Count != 0)
			{
				var acccumulatedMessage = validationMessages.Aggregate("", (current, validationMessage) => current + validationMessage);

				MessageBox.Show("Some errors occured:\n" + acccumulatedMessage, "", MessageBoxButtons.OK);
				return;
			}

			var selectedRegionId = (int) RegionsComboBox.SelectedValue;
			var selectedManagerId = (int) ManagerComboBox.SelectedValue;


			var cinema = new Cinema {Address = AddressTextBox.Text, Name = CinemaNameTextBox.Text, IdRegion = selectedRegionId, TelephoneNo = TelephoneTextBox.Text, IdManager =  selectedManagerId};

			_cinemaService.CreateCinema(cinema);

			_parentForm.Update();
			Close();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		List<string> ValidateForm()
		{
			var result = new List<string>();
			if(string.IsNullOrWhiteSpace(CinemaNameTextBox.Text))
				result.Add("- Please provide a name!\n");
			if(string.IsNullOrWhiteSpace(AddressTextBox.Text))
				result.Add("- Please provide an address!\n");
			if(string.IsNullOrWhiteSpace(TelephoneTextBox.Text))
				result.Add("- Please provide a telephone number!\n");

			return result;
		}

		private void AddCinemaSubForm_Load(object sender, EventArgs e)
		{
			var regions = _cinemaService.GetRegions();

			RegionsComboBox.DataSource = regions;
			RegionsComboBox.DisplayMember = "Name";
			RegionsComboBox.ValueMember = "Id";


			var potentialManagers = _cinemaService.GetEmployees();

			ManagerComboBox.DataSource = potentialManagers;
			ManagerComboBox.DisplayMember = "NameSurname";
			ManagerComboBox.ValueMember = "Id";
		}

	}
}
