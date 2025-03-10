using DataAccessLayer;
using DataBisnessLayer.Entities;
using DataBisnessLayer.EntityLists;
using System;
using System.Data;
using Microsoft.Data.SqlClient; 

namespace DataBisnessLayer.EntityManagers
{
	public class UserFavouriteManager
	{
		public static UserFavouriteList GetAll()
		{
			var dt = DBManager.GetQueryResult("SELECT * FROM UserFavourites");
			return MapDataTableToUserFavouriteList(dt);
		}

		public static UserFavourite GetByID(int userId, int productId)
		{
			string query = "SELECT * FROM UserFavourites WHERE UserId = @UserId AND ProductId = @ProductId";
			SqlParameter[] parameters = {
				new SqlParameter("@UserId", userId),
				new SqlParameter("@ProductId", productId)
			};

			var dt = DBManager.GetQueryResult(query, parameters);
			if (dt.Rows.Count > 0)
				return MapDataTableRowToUserFavourite(dt.Rows[0]);

			return null;
		}
		public static UserFavouriteList GetByUserId(int userId)
		{
			string query = "SELECT * FROM UserFavourites WHERE UserId = @UserId";
			SqlParameter[] parameters = {
				new SqlParameter("@UserId", userId)
			};

			var dt = DBManager.GetQueryResult(query, parameters);
			return MapDataTableToUserFavouriteList(dt);
		}
		public static UserFavouriteList GetByProductId(int productId)
		{
			string query = "SELECT * FROM UserFavourites WHERE ProductId = @ProductId";
			SqlParameter[] parameters = {
				new SqlParameter("@ProductId", productId)
			};

			var dt = DBManager.GetQueryResult(query, parameters);
			return MapDataTableToUserFavouriteList(dt);
		}
		public static UserFavourite GetSpecificUserFavourite(int userId,int productId)
		{
			string query = "SELECT * FROM UserFavourites WHERE UserId = @UserId AND ProductId = @ProductId";
			SqlParameter[] parameters = {
				new SqlParameter("@UserId", userId),
				new SqlParameter("@ProductId", productId)
			};
			var dr = DBManager.GetQueryResult(query, parameters);
			if (dr.Rows.Count > 0)
				return MapDataTableRowToUserFavourite(dr.Rows[0]);
			return null;
		}
		public static int Add(UserFavourite userFavourite)
		{
			string query = "INSERT INTO UserFavourites (UserId, ProductId) VALUES (@UserId, @ProductId)";
			SqlParameter[] parameters = {
				new SqlParameter("@UserId", userFavourite.UserId),
				new SqlParameter("@ProductId", userFavourite.ProductId)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Update(UserFavourite userFavourite)
		{
			string query = "UPDATE UserFavourites SET UserId = @UserId, ProductId = @ProductId WHERE UserId = @UserId AND ProductId = @ProductId";
			SqlParameter[] parameters = {
				new SqlParameter("@UserId", userFavourite.UserId),
				new SqlParameter("@ProductId", userFavourite.ProductId)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Delete(int userId, int productId)
		{
			string query = "DELETE FROM UserFavourites WHERE UserId = @UserId AND ProductId = @ProductId";
			SqlParameter[] parameters = {
				new SqlParameter("@UserId", userId),
				new SqlParameter("@ProductId", productId)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		static UserFavouriteList MapDataTableToUserFavouriteList(DataTable dt)
		{
			UserFavouriteList list = new UserFavouriteList();
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(MapDataTableRowToUserFavourite(dr));
			}
			return list;
		}

		static UserFavourite MapDataTableRowToUserFavourite(DataRow dr)
		{
			return new UserFavourite
			{
				UserId = Convert.ToInt32(dr["UserId"]),
				ProductId = Convert.ToInt32(dr["ProductId"])
			};
		}
	}
}
