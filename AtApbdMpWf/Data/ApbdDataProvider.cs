using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using AtApbdMpWf.Entity;

namespace AtApbdMpWf.Data
{
	public class ApbdDataProvider : IApbdDataProvider
	{
		private SqlConnection _sqlConnection;

		public ApbdDataProvider(SqlConnection sqlConnection)
		{
			_sqlConnection = sqlConnection;
		}

		private static SqlCommand CreateCommand(string commandText, SqlConnection connection, CommandType commandType)
		{
			var command = new SqlCommand { Connection = connection, CommandType = commandType };
			command.CommandText = commandText;

			return command;
		}

		private static SqlCommand CreateCommand(string commandText, SqlConnection connection, CommandType commandType, ValuedSqlParameter[] sqlParameters)
		{
			var command = CreateCommand(commandText, connection, commandType);
			command.CommandText = commandText;

			foreach (var valuedSqlParameter in sqlParameters)
			{
				var sqlParameter = new SqlParameter(valuedSqlParameter.ParameterName, valuedSqlParameter.Type) {Value = valuedSqlParameter.Value};
				command.Parameters.Add(sqlParameter);
			}

			return command;
		}

		/// <summary>
		///	
		/// </summary>
		/// <param name="commandText"></param>
		/// <param name="connection"></param>
		/// <param name="commandType"></param>
		/// <param name="sqlParameters"></param>
		/// <returns></returns>
		private static SqlCommand CreateCommand(string commandText, SqlConnection connection, CommandType commandType, ValuedSqlParameter sqlParameters)
		{
			var command = CreateCommand(commandText, connection, commandType, new[] {sqlParameters});

			return command;
		}

		/// <summary>
		///		Finds the Cinema by it's unique identifier.
		/// </summary>
		/// <param name="id">
		///		Identifier.
		/// </param>
		/// <returns>
		///		A reference to Cinema object if found, if not - null.
		/// </returns>
		public Cinema GetCinema(int id)
		{
			var command = CreateCommand("GetCinemas", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "@IdCinema", id));

			Cinema cinema;

			using (var reader = command.ExecuteReader())
			{
				if (!reader.HasRows) return null;

				reader.Read();
				cinema = Cinema.Create(reader);
	
			}
			return cinema;
		}


		/// <summary>
		///		Returns a collection of all the cinemas.
		/// </summary>
		/// <returns>
		///		A collection of all the cinemas
		/// </returns>
		public IEnumerable<Cinema> GetAllCinemas()
		{
			var command = CreateCommand("GetCinemas", _sqlConnection, CommandType.StoredProcedure);

			var cinemas = new List<Cinema>();

			using (var reader = command.ExecuteReader())
			{
				if (!reader.HasRows) return new List<Cinema>();

				while (reader.Read())
				{
					cinemas.Add(Cinema.Create(reader));
				}	
			}

			return cinemas;
		}

		public void CreateCinema(Cinema cinema)
		{
			ValuedSqlParameter	name = new ValuedSqlParameter(SqlDbType.VarChar, "Name", cinema.Name),
								address = new ValuedSqlParameter(SqlDbType.VarChar, "Address", cinema.Address),
								telNo = new ValuedSqlParameter(SqlDbType.VarChar, "TelephoneNo", cinema.TelephoneNo),
								idRegion = new ValuedSqlParameter(SqlDbType.Int, "IdRegion", cinema.IdRegion),
								idManager = new ValuedSqlParameter(SqlDbType.Int, "IdManager", cinema.IdManager);

			var parameters = new[] {name, address, telNo, idRegion, idManager};

			var command = CreateCommand("CreateCinema", _sqlConnection, CommandType.StoredProcedure, parameters);

			command.ExecuteNonQuery();
		}

		public void DeleteCinema(Cinema cinema)
		{
			DeleteCinema(cinema.Id);
		}

		public void DeleteCinema(int id)
		{
			var command = CreateCommand("DeleteCinema", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "IdCInema", id));

			command.ExecuteNonQuery();
		}

		public void Update(Cinema cinema)
		{
			ValuedSqlParameter name = new ValuedSqlParameter(SqlDbType.VarChar, "Name", cinema.Name),
					address = new ValuedSqlParameter(SqlDbType.VarChar, "Address", cinema.Address),
					telNo = new ValuedSqlParameter(SqlDbType.VarChar, "TelephoneNo", cinema.TelephoneNo),
					id = new ValuedSqlParameter(SqlDbType.Int, "IdCinema", cinema.Id);

			var parameters = new[] {name, address, telNo, id};

			var command = CreateCommand("UpdateBasicCinemaData", _sqlConnection, CommandType.StoredProcedure, parameters);

			command.ExecuteNonQuery();
		}

		/// <summary>
		///		Find the Employee who is the manager of the given Cinema.
		/// </summary>
		/// <param name="cinema">
		///		Cinema for which we find the managing Employee.
		/// </param>
		/// <returns>
		///		Employee object if found, if not - null.
		/// </returns>
		public Employee GetManager(Cinema cinema)
		{
			var command = CreateCommand("GetManagerForCinema", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "@IdCinema", cinema.Id));


			Employee employee;

			using (var reader = command.ExecuteReader())
			{
				if (!reader.HasRows) return null;

				reader.Read();

				employee = Employee.Create(reader);	
			}

			return employee;
		}

		public void UpdateManager(Cinema cinema, Employee newManager)
		{
			ValuedSqlParameter	cinemaParam = new ValuedSqlParameter(SqlDbType.Int, "IdCinema", cinema.Id),
								managerParam = new ValuedSqlParameter(SqlDbType.Int, "IdManager", newManager.Id);

			var paramArray = new[] {cinemaParam, managerParam};

			var command = CreateCommand("UpdateManagerForCinema", _sqlConnection, CommandType.StoredProcedure, paramArray);

			command.ExecuteNonQuery();
		}

		/// <summary>
		///		Returns a collection of employees in the given Cinema.
		/// </summary>
		/// <param name="cinema">
		///		Cinema for which we find it's employees.
		/// </param>
		/// <returns>
		///		Collection of Employees.
		/// </returns>
		public IEnumerable<Employee> GetAllEmployees(Cinema cinema)
		{
			var command = CreateCommand("GetAllEmployeesForCinema", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "@IdCinema", cinema.Id));

			var employees = new List<Employee>();

			using (var reader = command.ExecuteReader())
			{
				if (!reader.HasRows) return employees;
				while (reader.Read())
				{
					employees.Add(Employee.Create(reader));
				}	
			}

			return employees;
		}


		/// <summary>
		///		Returns a collection of projections for the given Cinema.
		/// </summary>
		/// <param name="cinema">
		///		Cinema for which we find all projections.
		/// </param>
		/// <returns>
		///		A collection of projections.
		/// </returns>
		public IEnumerable<Projection> GetAllProjections(Cinema cinema)
		{
			var command = CreateCommand("GetAllProjectionsForCinema", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "IdCinema", cinema.Id));

			var projections = new List<Projection>();

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					projections.Add(Projection.Create(reader));
				}	
			}

			return projections;
		}


		/// <summary>
		///		Returns a collection of projections that happen for given Cinema for given day.
		/// </summary>
		/// <param name="cinema">
		///		Cinema for which we find occuring Projections.
		/// </param>
		/// <param name="dateTime">
		///		DateTime for which we find occuring Projections.
		/// </param>
		/// <returns>
		///		Collection of projections. Empty or populated.
		/// </returns>
		public IEnumerable<Projection> GetAllProjections(Cinema cinema, DateTime dateTime)
		{
			ValuedSqlParameter cinemaIdParameter = new ValuedSqlParameter(SqlDbType.Int, "IdCinema", cinema.Id),
				dateTimeParameter = new ValuedSqlParameter(SqlDbType.DateTime, "DateTime", dateTime);

			var command = CreateCommand("GetAllProjectionsForGivenDayForGivenCinema", _sqlConnection, CommandType.StoredProcedure, new[] {cinemaIdParameter, dateTimeParameter});

			var projections = new List<Projection>();

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					projections.Add(Projection.Create(reader));
				}
			}

			return projections;

		}

		/// <summary>
		///		Returns the details of the region identified by it's id.
		/// </summary>
		/// <param name="id"></param>
		/// <returns>
		///		Region reference if found, if not - null.
		/// </returns>
		public Region GetRegion(int id)
		{
			var command = CreateCommand("GetRegion", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "@IdRegion", id));

			Region region;

			using (var reader = command.ExecuteReader())
			{
				if (!reader.HasRows) return null;

				reader.Read();

				region = Region.Create(reader);	
			}
			
			return region;
		}


		/// <summary>
		///		Find the parent region for the given Cinema.
		/// </summary>
		/// <param name="cinema"></param>
		/// <returns></returns>
		public Region GetRegion(Cinema cinema)
		{
			return GetRegion(cinema.IdRegion);
		}

		public IEnumerable<ProjectionRoom> GetProjectionRooms(Cinema cinema)
		{
			var cinemaParameter = new ValuedSqlParameter(SqlDbType.Int, "IdCinema", cinema.Id);

			var command = CreateCommand("GetProjectionRoomsForCinema", _sqlConnection, CommandType.StoredProcedure, cinemaParameter);

			var projectionRooms = new List<ProjectionRoom>();

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					projectionRooms.Add(ProjectionRoom.Create(reader));
				}
			}

			return projectionRooms;
		}

		public IEnumerable<Projection> GetAllProjections()
		{
			throw new NotImplementedException();
		}

		public void AddProjection(Projection projection, ProjectionRoom projectionRoom)
		{
			var projectionRoomParam = new ValuedSqlParameter(SqlDbType.Int, "IdProjectionRoom", projectionRoom.Id);
			var dateTimeParam = new ValuedSqlParameter(SqlDbType.DateTime, "DateTime", projection.DateTime);
			var lengthParam = new ValuedSqlParameter(SqlDbType.Int, "Length", projection.Length);

			var paramArray = new[] {projectionRoomParam, dateTimeParam, lengthParam};

			var command = CreateCommand("InsertProjectionForGivenDayForGivenCinema", _sqlConnection, CommandType.StoredProcedure, paramArray);

			command.ExecuteNonQuery();
		}

		public void DeleteProjection(int id)
		{
			var projectionParam = new ValuedSqlParameter(SqlDbType.Int, "IdProjection", id);

			var command = CreateCommand("DeleteProjection", _sqlConnection, CommandType.StoredProcedure, projectionParam);

			command.ExecuteNonQuery();
		}

		public void UpdateProjection(Projection projection)
		{
			ValuedSqlParameter	projectionParam = new ValuedSqlParameter(SqlDbType.Int, "IdProjection", projection.Id), 
								dateParam = new ValuedSqlParameter(SqlDbType.DateTime, "DateTime", projection.DateTime),
								lengthParameter = new ValuedSqlParameter(SqlDbType.Int, "Length", projection.Length),
								projectionRoomParam = new ValuedSqlParameter(SqlDbType.Int, "IdProjectionRoom", projection.IdProjectionRoom);

			var paramArray = new[] {projectionParam, dateParam, lengthParameter, projectionRoomParam};

			var command = CreateCommand("UpdateProjectionInCinema", _sqlConnection, CommandType.StoredProcedure, paramArray);

			command.ExecuteNonQuery();
		}

		public Projection GetProjection(int id)
		{
			var command = CreateCommand("GetProjection", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "IdProjection", id));

			Projection projection;

			using (var reader = command.ExecuteReader())
			{
				projection = !reader.Read() ? null : Projection.Create(reader);
			}

			return projection;
		}

		public IEnumerable<Employee> GetEmployeesByRegion(int IdRegion)
		{
			var command = CreateCommand("GetEmployeesByRegion", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "IdRegion", IdRegion));

			var employees = new List<Employee>();

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					employees.Add(Employee.Create(reader));
				}
			}

			return employees;
		}

		public IEnumerable<Employee> GetEmployeesByRegion(Region region)
		{
			return GetEmployeesByRegion(region.Id);
		}

		public IEnumerable<Cinema> GetCinemasByRegion(int IdRegion)
		{
			var command = CreateCommand("GetCinemasByRegion", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "IdRegion", IdRegion));

			var cinemas = new List<Cinema>();

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					cinemas.Add(Cinema.Create(reader));
				}
			}

			return cinemas;
		}

		public IEnumerable<Cinema> GetCinemasByRegion(Region region)
		{
			return GetCinemasByRegion(region.Id);
		}

		public IEnumerable<Region> GetRegions()
		{
			var command = CreateCommand("GetRegions", _sqlConnection, CommandType.StoredProcedure);

			var regions = new List<Region>();

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					regions.Add(Region.Create(reader));
				}
			}

			return regions;
		}

		public IEnumerable<Employee> GetEmployees()
		{
			var command = CreateCommand("GetEmployees", _sqlConnection, CommandType.StoredProcedure);

			var employees = new List<Employee>();

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					employees.Add(Employee.Create(reader));
				}
			}

			return employees;

		}

		public IEnumerable<Employee> GetEmployeesWithNoCinemaAttachment()
		{
			var command = CreateCommand("GetEmployeesWithNoCinemaAttachement", _sqlConnection, CommandType.StoredProcedure);

			var employees = new List<Employee>();

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					employees.Add(Employee.Create(reader));
				}
			}

			return employees;
		}

		public void AddEmployeeToCinema(int idCinema, Employee employee)
		{
			ValuedSqlParameter name = new ValuedSqlParameter(SqlDbType.VarChar, "Name", employee.Name),
				surname = new ValuedSqlParameter(SqlDbType.VarChar, "Surname", employee.Surname),
				telephone = new ValuedSqlParameter(SqlDbType.VarChar, "TelephoneNo", employee.TelephoneNo),
				email = new ValuedSqlParameter(SqlDbType.VarChar, "Email", employee.Email),
				idCinemaParam = new ValuedSqlParameter(SqlDbType.Int, "IdCinema", idCinema);

			var parameters = new[] {name, surname, telephone, email, idCinemaParam};

			var command = CreateCommand("AddEmployeeToCinema", _sqlConnection, CommandType.StoredProcedure, parameters);

			command.ExecuteNonQuery();
		}

		public void AddExsitingEmployeeToCinema(int idCinema, int idEmloyee)
		{
			var parameterers = new[] {new ValuedSqlParameter(SqlDbType.Int, "IdCinema", idCinema), new ValuedSqlParameter(SqlDbType.Int, "IdEmployee", idEmloyee)};

			var command = CreateCommand("AddExistingEmployeeToCinema", _sqlConnection, CommandType.StoredProcedure, parameterers);

			command.ExecuteNonQuery();
		}

		public Employee GetEmployee(int idEmployee)
		{
			var command = CreateCommand("GetEmployee", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "IdEmployee", idEmployee));

			Employee employee;

			using (var reader = command.ExecuteReader())
			{
				if (!reader.HasRows) return null;

				reader.Read();

				employee = Employee.Create(reader);	
			}
			
			return employee;			
		}

		public void UpdateEmployee(Employee employee)
		{
			var parameters = new[]
			{
				new ValuedSqlParameter(SqlDbType.Int, "IdEmployee", employee.Id),
				new ValuedSqlParameter(SqlDbType.VarChar, "Name", employee.Name),
				new ValuedSqlParameter(SqlDbType.VarChar, "Surname", employee.Surname),
				new ValuedSqlParameter(SqlDbType.VarChar, "TelephoneNo", employee.TelephoneNo),
				new ValuedSqlParameter(SqlDbType.VarChar, "Email", employee.Email)
			};

			var command = CreateCommand("UpdateEmployee", _sqlConnection, CommandType.StoredProcedure, parameters);

			command.ExecuteNonQuery();
		}

		public void DeleteEmployee(int idEmployee)
		{
			var command = CreateCommand("DeleteEmployee", _sqlConnection, CommandType.StoredProcedure, new ValuedSqlParameter(SqlDbType.Int, "IdEmployee", idEmployee));

			command.ExecuteNonQuery();
		}

		public void EditRegion(Region region)
		{
			var command = CreateCommand("EditRegion", _sqlConnection, CommandType.StoredProcedure, new[] {new ValuedSqlParameter(SqlDbType.Int, "IdRegion", region.Id), new ValuedSqlParameter(SqlDbType.VarChar, "Name", region.Name)});

			command.ExecuteNonQuery();
		}

		public void DeleteRegion(Region region)
		{
			DeleteRegion(region.Id);
		}

		public void DeleteRegion(int idRegion)
		{
			var command = CreateCommand("DeleteRegion", _sqlConnection, CommandType.StoredProcedure, new[] { new ValuedSqlParameter(SqlDbType.Int, "IdRegion", idRegion) });

			command.ExecuteNonQuery();
		}

		public void AddRegion(Region region)
		{
			AddRegion(region.Name);
		}

		public void AddRegion(string regionName)
		{
			var command = CreateCommand("AddRegion", _sqlConnection, CommandType.StoredProcedure, new[] { new ValuedSqlParameter(SqlDbType.VarChar, "Name", regionName) });

			command.ExecuteNonQuery();
		}
	}
}