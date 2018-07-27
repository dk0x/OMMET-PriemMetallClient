using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[Text("Закупочные цены на металлолом")]
	public class BuyPriceMetall : BaseRecord
	{
		[Text("Категория лома")]
		public string Category { get; set; } = "";
		[Text("Условия поставки")]
		public string Description { get; set; } = "";
		[Text("Цена за 1 тонну, руб. (без НДС)")]
		public decimal Price { get; set; } = 0;

		public override string ToString() => $"Категория лома: '{Category}', Цена за тонну: {Price.ToString("N")} руб.";
		
	}
}
