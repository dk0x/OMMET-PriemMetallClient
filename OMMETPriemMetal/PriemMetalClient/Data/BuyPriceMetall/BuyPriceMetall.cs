using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	public class BuyPriceMetall
	{
		public int Id { get; set; } = 0;
		public Guid Guid { get; set; } = Guid.Empty;
		public string Category { get; set; } = "";
		public string Description { get; set; } = "";
		public int Price { get; set; } = 0;

		public override string ToString()
		{
			return $"ID = {Id}, Cat = {Category}, Price = {Price}";
		}
	}
}
