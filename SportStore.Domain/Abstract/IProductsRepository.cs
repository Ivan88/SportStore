using System.Collections.Generic;
using SportStore.Domain.Entities;

namespace SportStore.Domain.Abstract
{
	public interface IProductsRepository
	{
		IEnumerable<Product> Products { get; }
	}
}
