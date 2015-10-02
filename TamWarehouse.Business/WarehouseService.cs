using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TamWarehouse.DataAccess;
using TamWarehouse.Entity;

namespace TamWarehouse.Business
{
	class WarehouseService : IWarehouseService
	{
		TamWarehouseContext ctx = new TamWarehouseContext();

		public async Task<List<Product>> SearchProduct(int StaffID)
		{
			List<Product> _productlist;

			if (StaffID == 0)
			{
				_productlist = await ctx.Products.ToListAsync();
			}
			else
			{
				_productlist = await ctx.Products.Where(x => x.Staff.ID == StaffID).ToListAsync();
			}

			return _productlist;

		}

		public async Task<List<Product>> SearchProductExpired(DateTime ExpiredDate)
		{
			List<Product> _productlist;
			_productlist = await ctx.Products.ToListAsync();
			return _productlist;
		}

		public async Task<List<Product>> SearchProductbyStockDate(DateTime ExpireDate)
		{
			List<Product> _productlist;
			_productlist = await ctx.Products.ToListAsync();
			return _productlist;
		}

		public async Task<List<Product>> SearchProductbyPrice(decimal Price, string criteria)
		{
			List<Product> _productlist;
			_productlist = await ctx.Products.ToListAsync();
			return _productlist;
		}

		public async Task<Product> GetProductDetail(int ProductID)
		{
			var _product = await ctx.Products.Where(x => x.ID == ProductID).FirstOrDefaultAsync();
			return _product;
		}
	}
}
