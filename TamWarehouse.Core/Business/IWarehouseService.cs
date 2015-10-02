using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamWarehouse.Entity;

namespace TamWarehouse.Business
{
	public interface IWarehouseService
	{
		Task<List<Product>> SearchProduct(int StaffID);

		Task<List<Product>> SearchProductExpired(DateTime ExpiredDate);

		Task<List<Product>> SearchProductbyStockDate(DateTime ExpireDate);

		Task<List<Product>> SearchProductbyPrice(decimal Price, string criteria);

		Task<Product> GetProductDetail(int ProductID);
	}
}
