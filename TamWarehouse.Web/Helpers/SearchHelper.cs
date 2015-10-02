using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TamWarehouse.Business;
using TamWarehouse.DataAccess;
using TamWarehouse.Web.Models;

namespace TamWarehouse.Web.Helpers
{
	public class SearchHelper
	{
		public static IWarehouseService _warehouseBusinessService;

		public SearchHelper(IWarehouseService service)
		{
			_warehouseBusinessService = service;
		}

		public async Task<SearchProductModel> SearchProduct(int productID)
		{
			using (var context = new TamWarehouseContext())
			{
				var searchProducts = await _warehouseBusinessService.SearchProduct(0);

				var searchResults = new SearchProductModel();
				searchResults.Products = searchProducts;
				searchResults.numberofProduct = searchProducts.Count();
				searchResults.searchingtime = DateTime.Now;

				return (searchResults);
			}
		}
	}
}