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
	public partial class AddRegionSubForm : Form
	{
		private CinemaService _cinemaService;
		private readonly ManagementForm _parentForm;

		public AddRegionSubForm(CinemaService cinemaService, ManagementForm parentForm)
		{
			_cinemaService = cinemaService;
			_parentForm = parentForm;
			InitializeComponent();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var regionName = RegionNameTextBox.Text;

			if (string.IsNullOrWhiteSpace(regionName))
			{
				MessageBox.Show("Please provide a name!", "Error", MessageBoxButtons.OK);
				return;
			}

			_cinemaService.AddRegion(regionName);

			_parentForm.Update();
			Close();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}


	}
}
