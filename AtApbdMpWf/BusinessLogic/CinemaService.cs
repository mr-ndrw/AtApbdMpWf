using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using AtApbdMpWf.Data;
using AtApbdMpWf.Entity;
using AtApbdMpWf.ViewModels;

namespace AtApbdMpWf.BusinessLogic
{
	public class CinemaService
	{
		private readonly IApbdDataProvider _dataConnection;

		public CinemaService(IApbdDataProvider dataConnection)
		{
			_dataConnection = dataConnection;
		}

		public Projection GetProjection(int id)
		{
			try
			{
				return _dataConnection.GetProjection(id);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new Projection(){DateTime = DateTime.Now, Id=0, IdProjectionRoom = 0, Length = 0};
		}


		public Cinema GetCinema(int id)
		{
			try
			{
				return _dataConnection.GetCinema(id);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
			return new Cinema(){Address = "ERROR", Id=0, IdManager = 0, IdRegion = 0, Name = "ERROR", TelephoneNo = "ERROR"};
		}

		public List<Cinema> GetAllCinemas()
		{
			try
			{
				return _dataConnection.GetAllCinemas().ToList();
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Cinema>();
		}

		public void CreateCinema(Cinema cinema)
		{
			try
			{
				_dataConnection.CreateCinema(cinema);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public void DeleteCinema(Cinema cinema)
		{
			try
			{
				_dataConnection.DeleteCinema(cinema);	
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public void DeleteCinema(int id)
		{
			try
			{
				_dataConnection.DeleteCinema(id);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public void Update(Cinema cinema)
		{
			try
			{
				_dataConnection.Update(cinema);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public Employee GetManager(Cinema cinema)
		{
			try
			{
				return _dataConnection.GetManager(cinema);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new Employee() {Email = "ERROR", Id = -1, Name = "ERROR", Surname = "ERROR", TelephoneNo = "Error"};
		}

		public void UpdateManager(Cinema cinema, Employee newManager)
		{
			try
			{
				_dataConnection.UpdateManager(cinema, newManager);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public List<Employee> GetAllEmployees(Cinema cinema)
		{
			try
			{
				return _dataConnection.GetAllEmployees(cinema).ToList();
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Employee>();
		}

		public List<Employee> GetAllEmployees(int idCinema)
		{
			try
			{
				return _dataConnection.GetAllEmployees(new Cinema { Id = idCinema }).ToList();
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Employee>();
		}

		public List<Employee> GetEmployees()
		{
			try
			{
				return _dataConnection.GetEmployees().ToList();
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Employee>();
		}

		public List<Projection> GetAllProjections(Cinema cinema)
		{
			try
			{
				return _dataConnection.GetAllProjections(cinema).ToList();
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Projection>();
		}

		public List<Projection> GetAllProjections(Cinema cinema, DateTime dateTime)
		{
			try
			{
				return _dataConnection.GetAllProjections(cinema, dateTime)
				.ToList();
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Projection>();
		}

		public List<ProjectionRoom> GetProjectionRooms(Cinema cinema)
		{
			try
			{
				return _dataConnection.GetProjectionRooms(cinema).ToList();
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<ProjectionRoom>();
		}

		public void AddProjection(Projection projection, ProjectionRoom projectionRoom)
		{
			try
			{
				_dataConnection.AddProjection(projection, projectionRoom);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public Region GetRegion(int id)
		{
			try
			{
				return _dataConnection.GetRegion(id);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new Region(){Id=-1, Name = "Error"};
		}

		public Region GetRegion(Cinema cinema)
		{
			try
			{
				return _dataConnection.GetRegion(cinema);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new Region() { Id = -1, Name = "Error" };
		}

		public void DeleteProjection(int id)
		{
			try
			{
				_dataConnection.DeleteProjection(id);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public void UpdateProjection(Projection projection)
		{
			try
			{
				_dataConnection.UpdateProjection(projection);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public IEnumerable<Employee> GetEmployeesByRegion(int IdRegion)
		{
			try
			{
				return _dataConnection.GetEmployeesByRegion(IdRegion);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Employee>();
		}

		public IEnumerable<Employee> GetEmployeesByRegion(Region region)
		{
			try
			{
				return _dataConnection.GetEmployeesByRegion(region);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Employee>();
		}

		public IEnumerable<Cinema> GetCinemasByRegion(int IdRegion)
		{
			try
			{
				return _dataConnection.GetCinemasByRegion(IdRegion);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Cinema>();
		}

		public IEnumerable<Cinema> GetCinemasByRegion(Region region)
		{
			try
			{
				return _dataConnection.GetCinemasByRegion(region);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Cinema>();
		}

		public IEnumerable<Region> GetRegions()
		{
			try
			{
				return _dataConnection.GetRegions();
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Region>();
		}

		public List<RegionWithCinemasViewModel> GetRegionsWithCinemas()
		{
			IEnumerable<Region> regions = new List<Region>();
			try
			{
				regions = GetRegions();
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			var result = regions.Select(region => 
					new RegionWithCinemasViewModel{Region = region, Cinemas = GetCinemasByRegion(region).ToList()})
					.ToList();

			return result;
		}

		public List<Employee> GetEmployeesWithNoCinemaAttachement()
		{
			try
			{
				return _dataConnection.GetEmployeesWithNoCinemaAttachment().ToList();
			}
				catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new List<Employee>();
		}

		public void AddEmployeeToCinema(int idCinema, Employee employee)
		{
			try
			{
				_dataConnection.AddEmployeeToCinema(idCinema, employee);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public void AddExsistingEmployeeToCinema(int idCInema, Employee employee)
		{
			try
			{
				_dataConnection.AddExsitingEmployeeToCinema(idCInema, employee.Id);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}


		public Employee GetEmloyee(int idEmployee)
		{
			try
			{
				return _dataConnection.GetEmployee(idEmployee);	
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

			return new Employee() { Email = "ERROR", Id = -1, Name = "ERROR", Surname = "ERROR", TelephoneNo = "Error" };
		}

		public void UpdateEmployee(Employee employee)
		{
			try
			{
				_dataConnection.UpdateEmployee(employee);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public void DeleteEmployee(int idEmployee)
		{

			try
			{
				_dataConnection.DeleteEmployee(idEmployee);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}

		}

		public void AddRegion(string regionName)
		{
			try
			{
				_dataConnection.AddRegion(regionName);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public void DeleteRegion(Region region)
		{
			DeleteRegion(region.Id);
		}

		public void DeleteRegion(int idRegion)
		{
			try
			{
				_dataConnection.DeleteRegion(idRegion);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public void EditRegion(Region region)
		{
			try
			{
				_dataConnection.EditRegion(region);
			}
			catch (SqlException sqlException)
			{
				MessageBox.Show("An error occured.\nDetails:\n" + sqlException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Connection to database is unavailable\nDetails:\n" + ioException.Message, "Error", MessageBoxButtons.OK);
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nDetails:\n" + exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

	}
}