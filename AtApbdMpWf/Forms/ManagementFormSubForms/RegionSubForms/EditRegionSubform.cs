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
	public partial class EditRegionSubform
	{
		private CinemaService _cinemaService;
		private Region _editedRegion;
		public EditRegionSubform(CinemaService cinemaService, Region editedRegion)
		{
			_cinemaService = cinemaService;
			_editedRegion = editedRegion;
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

			_editedRegion.Name = regionName;

			_cinemaService.EditRegion(_editedRegion);

			Close();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void EditRegionSubform_Load(object sender, EventArgs e)
		{
			RegionNameTextBox.Text = _editedRegion.Name;
		}


	}
}
