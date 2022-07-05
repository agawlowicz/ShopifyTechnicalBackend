using System;
using System.Data;
using Dapper;
using ShopifySoftwareDeveloperInternship.Models;

namespace ShopifySoftwareDeveloperInternship
{
	public class DeletionRepository : IDeletionRepository
	{
		private readonly IDbConnection _conn;

		public DeletionRepository(IDbConnection conn)
		{
			_conn = conn;
		}

		public void DeleteProduct(Deleted product)
		{
			_conn.Execute("INSERT INTO deletions (ProductID, Name, Cost, Stock, Comments) VALUES (@id, @name, @cost, @stock, @comments);",
				new { id = product.ProductID, name = product.Name, cost = product.Cost, stock = product.Stock, comments = product.Comment });
		}
	}
}
