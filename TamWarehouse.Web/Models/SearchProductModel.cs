using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamWarehouse.Entity;

namespace TamWarehouse.Web.Models
{
	public class SearchProductModel
	{
		public int numberofProduct { get; set; }
		public IEnumerable<Product> Products { get; set; }
		public DateTime searchingtime { get; set; }
	}
}