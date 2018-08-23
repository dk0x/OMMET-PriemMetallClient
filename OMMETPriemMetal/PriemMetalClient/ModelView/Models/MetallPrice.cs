using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[RecordInfo("Категория металла, цена")]
	public class MetallPrice : BaseRecord
	{
		[RecordInfo("Категория лома")]
		public string Category { get; set; } = string.Empty;
		[RecordInfo("Номенклатура")]
		public string Nomenklatura { get; set; } = string.Empty;
		[RecordInfo("Условия поставки", TextMultilane = true, TableNoColumn = true, TableNoFilter = true)]
		public string Description { get; set; } = string.Empty;
		[RecordInfo("Цена за 1 тонну, руб. (без НДС)", ToStringFormat = "C", DecimalDigits = 2)]
		public decimal Price { get; set; } = 0;

		public override string ToString() => $"{Category} Цена: {Price.ToString("C")}";
	}
}
