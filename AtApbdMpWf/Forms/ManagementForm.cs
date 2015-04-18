using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AtApbdMpWf.BusinessLogic;
using AtApbdMpWf.Entity;
using AtApbdMpWf.Forms.ManagementFormSubForms.RegionSubForms;

namespace AtApbdMpWf.Forms
{
	public partial class ManagementForm : Form
	{
		private readonly CinemaService _cinemaService;

		private List<Region> regions;
		private List<Cinema> cinemas;

		private int currentRegionIndex;
		private int currentCinemaIndex;

		private Region _currentlyViewedRegion;
		private Cinema _currentlyViewedCinema;

		public ManagementForm(CinemaService cinemaService)
		{
			_cinemaService = cinemaService;
			InitializeComponent();
		}

		private void ManagementForm_Load(object sender, EventArgs e)
		{
			Update();
		}

		public void Update()
		{
			regions = _cinemaService.GetRegions()
	.ToList();
			cinemas = _cinemaService.GetAllCinemas();

			_currentlyViewedRegion = regions[0];
			_currentlyViewedCinema = cinemas[0];

			SetCurrentlyViewedRegion();
			SetCurrentlyViewedCinema();
		}

		private void SetCurrentlyViewedRegion()
		{
			RegionNameLabel.Text = _currentlyViewedRegion.Name;
			CinemaDataGridView.DataSource = PopulateTableWithCinemas(_currentlyViewedRegion);

			CinemaDataGridView.Columns[0].Visible = false;
		}

		private void SetCurrentlyViewedCinema()
		{
			CinemaNameLabel.Text = _currentlyViewedCinema.Name;
			CinemaAddressLabel.Text = _currentlyViewedCinema.Address;
		}

		private DataTable PopulateTableWithCinemas(Region region)
		{
			var cinemasForRegion = _cinemaService.GetCinemasByRegion(region);

			var dataTable = new DataTable();

			dataTable.Columns.Add("Id");
			dataTable.Columns.Add("Name");
			dataTable.Columns.Add("Address");
			dataTable.Columns.Add("TelephoneNo");

			foreach (var cinema in cinemasForRegion)
			{
				dataTable.Rows.Add(cinema.Id, cinema.Name, cinema.Address, cinema.TelephoneNo);
			}

			return dataTable;
		}

		private void ChooseNextRegion()
		{
			if (currentRegionIndex + 1 == regions.Count)
				currentRegionIndex = 0;
			else
				currentRegionIndex += 1;
			_currentlyViewedRegion = regions[currentRegionIndex];
			SetCurrentlyViewedRegion();
		}

		private void ChoosePreviousRegion()
		{
			if (currentRegionIndex - 1 < 0)
				currentRegionIndex = regions.Count - 1;
			else
				currentRegionIndex -= 1;
			_currentlyViewedRegion = regions[currentRegionIndex];
			SetCurrentlyViewedRegion();
		}


		private void ChooseNextCinema()
		{
			if (currentCinemaIndex + 1 == cinemas.Count)
				currentCinemaIndex = 0;
			else
				currentCinemaIndex += 1;
			_currentlyViewedCinema = cinemas[currentCinemaIndex];
			SetCurrentlyViewedCinema();
		}

		private void ChoosePreviousCinema()
		{
			if (currentCinemaIndex - 1 < 0)
				currentCinemaIndex = cinemas.Count - 1;
			else
				currentCinemaIndex -= 1;
			_currentlyViewedCinema = cinemas[currentCinemaIndex];
			SetCurrentlyViewedCinema();
		}

		private void DeleteCurrentRegion()
		{
			var mbResult = MessageBox.Show("Are you sure you want to delete this region?\nAll connected cinemas and subsequently\nprojections will be deleted also.", "Delete?", MessageBoxButtons.YesNo);
			if (mbResult == DialogResult.Yes)
			{
				_cinemaService.DeleteRegion(_currentlyViewedRegion);
				Update();
			}

		}

		private void ShowEditRegionForm()
		{
			var form = new EditRegionSubform(_cinemaService, _currentlyViewedRegion);
			form.Show();
		}

		private void ShowAddRegionForm()
		{
			var form = new AddRegionSubForm(_cinemaService, this);
			form.Show();
		}

		private void ShowAddCinemaForm()
		{
			var form = new AddCinemaSubForm(_cinemaService, this);
			form.Show();
		}

		private void ShowEditCinemaForm()
		{
			var form = new EditCinemaSubForm(_cinemaService, _currentlyViewedCinema, this);
			form.Show();
		}

		private void DeleteCurrentCinema()
		{
			var mbResult = MessageBox.Show("Are you sure you want to delete this cinema?\nAll connected projections will be deleted also.", "Delete?", MessageBoxButtons.YesNo);
			if (mbResult == DialogResult.Yes)
			{
				_cinemaService.DeleteCinema(_currentlyViewedCinema);
				Update();
			}
		}


		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void PreviousCinemaButton_Click(object sender, EventArgs e)
		{
			ChoosePreviousCinema();
		}

		private void NextCinemaButton_Click(object sender, EventArgs e)
		{
			ChooseNextCinema();
		}

		private void PrevRegionButton_Click(object sender, EventArgs e)
		{
			ChoosePreviousRegion();
		}

		private void NextRegionButton_Click_1(object sender, EventArgs e)
		{
			ChooseNextRegion();
		}

		private void ManagementForm_KeyDown(object sender, KeyEventArgs e)
		{
			ProcessBareKeyPressed(e);
		}

		private void ProcessBareKeyPressed(KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.E:
				{
					ShowAddRegionForm();
					break;
				}
				case Keys.W:
				{
					ShowEditRegionForm();
					break;
				}
				case Keys.Q:
				{
					DeleteCurrentRegion();
					break;
				}
				case Keys.Z:
				{
					ChoosePreviousCinema();
					break;
				}
				case Keys.X:
				{
					ChooseNextRegion();
					break;
				}

				case Keys.A:
				{
					ShowAddCinemaForm();
					break;
				}
				case Keys.S:
				{
					ShowEditCinemaForm();
					break;
				}
				case Keys.D:
				{
					DeleteCurrentCinema();
					break;
				}
				case Keys.C:
				{
					ChoosePreviousCinema();
					break;
				}
				case Keys.V:
				{
					ChooseNextCinema();
					break;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ShowAddRegionForm();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ShowEditRegionForm();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DeleteCurrentRegion();
		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			ShowEditCinemaForm();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DeleteCurrentCinema();
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			ShowAddCinemaForm();
		}
	}
}
