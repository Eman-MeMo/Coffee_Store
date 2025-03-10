using DataAccessLayer;
using DataBisnessLayer.Entities;
using DataBisnessLayer.EntityLists;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBisnessLayer.EntityManagers
{
	public static class CategoryManager
	{
		public static CategoryList GetAll()
		{
			var dt = DBManager.GetQueryResult("SELECT * FROM Categories");
			return MapDataTableToCategoryList(dt);
		}

		public static Category GetByID(int id)
		{
			string query = "SELECT * FROM Categories WHERE ID = @ID";
			SqlParameter[] parameters = { new SqlParameter("@ID", id) };

			var dt = DBManager.GetQueryResult(query, parameters);

			if (dt.Rows.Count > 0)
				return MapDataTableRowToCategory(dt.Rows[0]);

			return null; 
		}

		public static int Add(Category category)
		{
			string query = "INSERT INTO Categories (Name) VALUES (@Name)";
			SqlParameter[] parameters = { new SqlParameter("@Name", category.Name) };

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Update(Category category)
		{
			string query = "UPDATE Categories SET Name = @Name WHERE ID = @ID";
			SqlParameter[] parameters = {
				new SqlParameter("@Name", category.Name),
				new SqlParameter("@ID", category.Id)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Delete(int id)
		{
			string query = "DELETE FROM Categories WHERE ID = @ID";
			SqlParameter[] parameters = { new SqlParameter("@ID", id) };

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		static CategoryList MapDataTableToCategoryList(DataTable dt)
		{
			CategoryList categoryList = new CategoryList();
			foreach (DataRow dr in dt.Rows)
			{
				categoryList.Add(MapDataTableRowToCategory(dr));
			}
			return categoryList;
		}

		static Category MapDataTableRowToCategory(DataRow dr)
		{
			Category category = new Category
			{
				Id = Convert.ToInt32(dr["ID"]),
				Name = dr["Name"].ToString()
			};
			return category;
		}
	}
}
