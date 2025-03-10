using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public static class DBManager
	{
		static SqlConnection connection;
		static DBManager()
		{
			string conn = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("DB_Connection").Value;
			connection = new SqlConnection(conn);
		}
		public static DataTable GetQueryResult(string query, SqlParameter[] parameters=null)
		{
			SqlCommand command = new SqlCommand(query, connection);
			if (parameters != null)
			{
				command.Parameters.AddRange(parameters);
			}
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			return dt;
		}
		public static int ExecuteNonQuery(string query, SqlParameter[] parameters=null)
		{
			int result = 0;
			SqlCommand command = new SqlCommand(query, connection);
			try
			{
				if (parameters != null)
				{
					command.Parameters.AddRange(parameters);
				}

				connection.Open();
				result = command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("SomwThing Error!");
			}
			finally
			{
				if (connection.State == ConnectionState.Open)
					connection.Close(); 
			}
			return result;
		}
	}
}
