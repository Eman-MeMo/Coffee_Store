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
	public static class ProductManager
	{
		public static ProductList GetAll()
		{
			var dt = DBManager.GetQueryResult("SELECT * FROM Products");
			return MapDataTableToProductList(dt);
		}

		public static Product GetByID(int id)
		{
			string query = "SELECT * FROM Products WHERE ID = @ID";
			SqlParameter[] parameters = { new SqlParameter("@ID", id) };

			var dt = DBManager.GetQueryResult(query, parameters);
			if (dt.Rows.Count > 0)
				return MapDataTableRowToProduct(dt.Rows[0]);

			return null; 
		}

		public static int Add(Product product)
		{
			string query = "INSERT INTO Products (Name, Price, Image, CategoryId) VALUES (@Name, @Price, @Image, @CategoryId)";
			SqlParameter[] parameters = {
				new SqlParameter("@Name", product.Name),
				new SqlParameter("@Price", product.Price),
				new SqlParameter("@Image", product.image),
				new SqlParameter("@CategoryId", product.CategoryId)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Update(Product product)
		{
			string query = "UPDATE Products SET Name = @Name, Price = @Price, Image = @Image, CategoryId = @CategoryId WHERE ID = @ID";
			SqlParameter[] parameters = {
				new SqlParameter("@Name", product.Name),
				new SqlParameter("@Price", product.Price),
				new SqlParameter("@Image", product.image),
				new SqlParameter("@CategoryId", product.CategoryId),
				new SqlParameter("@ID", product.Id)
			};

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		public static int Delete(int productId)
		{
			string query = "DELETE FROM Products WHERE ID = @ID";
			SqlParameter[] parameters = { new SqlParameter("@ID", productId) };

			return DBManager.ExecuteNonQuery(query, parameters);
		}

		static ProductList MapDataTableToProductList(DataTable dt)
		{
			ProductList productList = new ProductList();
			foreach (DataRow dr in dt.Rows)
			{
				productList.Add(MapDataTableRowToProduct(dr));
			}
			return productList;
		}

		static Product MapDataTableRowToProduct(DataRow dr)
		{
			return new Product
			{
				Id = Convert.ToInt32(dr["Id"]),
				Name = dr["Name"].ToString(),
				Price = Convert.ToDecimal(dr["Price"]),
				image = dr["Image"].ToString(),
				CategoryId = Convert.ToInt32(dr["CategoryId"])
			};
		}
	}
}
