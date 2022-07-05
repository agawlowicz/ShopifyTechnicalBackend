using System;
namespace ShopifySoftwareDeveloperInternship.Models
{
	public class Deleted : Product
	{
		public Product Product { get; set; }
		public string Comment { get; set; }
	}
}

