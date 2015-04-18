using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtApbdMpWf.Data;
using AtApbdMpWf.Forms;

namespace AtApbdMpWf
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var sqlConnection = new SqlConnection(Properties.Settings.Default.ApbdConnectionString);

			try
			{
				sqlConnection.Open();
			}
			catch (SqlException sqlException)
			{
				var message = sqlException.Message;
				MessageBox.Show(message + "\n\nExiting the application", "Error connecting to database", MessageBoxButtons.OK);
				return;
			}
			catch (InvalidOperationException ioException)
			{
				MessageBox.Show("Cannot open a connection without specifiying a data source or server\nor\nThe connection is already open.\nDetails:\n" + ioException.Message + "\n Application will exit now.", "Error", MessageBoxButtons.OK);
				return;
			}
			catch (Exception exception)
			{
				MessageBox.Show("An error occured\nApplication will exit." + exception.Message, "Error", MessageBoxButtons.OK);
				return;
			}

			var apbdProvider = new ApbdDataProvider(sqlConnection);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(apbdProvider));
		}
	}
}
