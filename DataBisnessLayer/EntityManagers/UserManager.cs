using DataAccessLayer;
using DataBisnessLayer.Entities;
using DataBisnessLayer.EntityLists;
using System;
using System.Data;
using Microsoft.Data.SqlClient; 

namespace DataBisnessLayer.EntityManagers
{
	public static class UserManager
	{
		public static UserList GetAll()
		{
			var dt = DBManager.GetQueryResult("SELECT * FROM Users");
			return MapDataTableToUserList(dt);
		}

		public static User GetByID(int id)
		{
			string query = "SELECT * FROM Users WHERE ID = @ID";
			SqlParameter[] parameters = {
				new SqlParameter("@ID", id)
			};

			var dt = DBManager.GetQueryResult(query, parameters);
			if (dt.Rows.Count > 0)
				return MapDataTableRowToUser(dt.Rows[0]);

			return null; 
		}
		public static User GetByEmail(string email) 
		{
			string query = "SELECT * FROM Users WHERE Email = @Email";
			SqlParameter[] parameters = {
				new SqlParameter("@Email", email)
			};
			var dt = DBManager.GetQueryResult(query, parameters);
			if (dt.Rows.Count > 0)
				return MapDataTableRowToUser(dt.Rows[0]);
			return null;
		}

		public static int Add(User user)
		{
			string query = "INSERT INTO Users (Username, Password, Email, Age, Address, Phone, roleID) VALUES (@Username, @Password, @Email, @Age, @Address, @Phone, @RoleID)";
			SqlParameter[] parameters = {
				new SqlParameter("@Username", user.Username),
				new SqlParameter("@Password", user.Password),
				new SqlParameter("@Email", user.Email),
				new SqlParameter("@Age", user.Age),
				new SqlParameter("@Address", user.Address),
				new SqlParameter("@Phone", user.Phone),
				new SqlParameter("@RoleID", user.roleID)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Update(User user)
		{
			string query = "UPDATE Users SET Username = @Username, Password = @Password, Email = @Email, Age = @Age, Address = @Address, Phone = @Phone, roleID = @RoleID WHERE ID = @ID";
			SqlParameter[] parameters = {
				new SqlParameter("@Username", user.Username),
				new SqlParameter("@Password", user.Password),
				new SqlParameter("@Email", user.Email),
				new SqlParameter("@Age", user.Age),
				new SqlParameter("@Address", user.Address),
				new SqlParameter("@Phone", user.Phone),
				new SqlParameter("@RoleID", user.roleID),
				new SqlParameter("@ID", user.Id)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Delete(int id)
		{
			string query = "DELETE FROM Users WHERE ID = @ID";
			SqlParameter[] parameters = {
				new SqlParameter("@ID", id)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		static UserList MapDataTableToUserList(DataTable dt)
		{
			UserList userList = new UserList();
			foreach (DataRow dr in dt.Rows)
			{
				userList.Add(MapDataTableRowToUser(dr));
			}
			return userList;
		}

		static User MapDataTableRowToUser(DataRow dr)
		{
			return new User
			{
				Id = Convert.ToInt32(dr["ID"]),
				Username = dr["Username"].ToString(),
				Password = dr["Password"].ToString(),
				Email = dr["Email"].ToString(),
				Age = Convert.ToInt32(dr["Age"]),
				Address = dr["Address"].ToString(),
				Phone = dr["Phone"].ToString(),
				roleID = Convert.ToInt32(dr["roleID"])
			};
		}
	}
}
