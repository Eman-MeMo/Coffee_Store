using DataAccessLayer;
using DataBisnessLayer.Entities;
using DataBisnessLayer.EntityLists;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace DataBisnessLayer.EntityManagers
{
	public static class RoleManager
	{
		public static RoleList GetAll()
		{
			var dt = DBManager.GetQueryResult("SELECT * FROM Roles");
			return MapDataTableToRoleList(dt);
		}

		public static Role GetByID(int id)
		{
			string query = "SELECT * FROM Roles WHERE ID = @ID";
			SqlParameter[] parameters = { new SqlParameter("@ID", id) };

			var dt = DBManager.GetQueryResult(query, parameters);
			if (dt.Rows.Count > 0)
				return MapDataTableRowToRole(dt.Rows[0]);

			return null; 
		}

		public static int Add(Role role)
		{
			string query = "INSERT INTO Roles (Name) VALUES (@Name)";
			SqlParameter[] parameters = { new SqlParameter("@Name", role.Name) };

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Update(Role role)
		{
			string query = "UPDATE Roles SET Name = @Name WHERE ID = @ID";
			SqlParameter[] parameters = {
				new SqlParameter("@Name", role.Name),
				new SqlParameter("@ID", role.Id)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Delete(int id)
		{
			string query = "DELETE FROM Roles WHERE ID = @ID";
			SqlParameter[] parameters = { new SqlParameter("@ID", id) };

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		static RoleList MapDataTableToRoleList(DataTable dt)
		{
			RoleList roleList = new RoleList();
			foreach (DataRow dr in dt.Rows)
			{
				roleList.Add(MapDataTableRowToRole(dr));
			}
			return roleList;
		}

		static Role MapDataTableRowToRole(DataRow dr)
		{
			return new Role
			{
				Id = Convert.ToInt32(dr["Id"]),
				Name = dr["Name"].ToString()
			};
		}
	}
}
