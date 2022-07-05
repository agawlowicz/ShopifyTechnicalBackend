using System;
using ShopifySoftwareDeveloperInternship.Models;

namespace ShopifySoftwareDeveloperInternship
{
	public interface IDeletionRepository
	{
		public void DeleteProduct(Deleted toDelete);
	}
}

