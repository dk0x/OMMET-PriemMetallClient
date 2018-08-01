using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	public class PSADocumentMetall : BaseRecord
	{
		[RecordInfo("Категория металла")]
		public string Category { get; set; } = null;
		[RecordInfo("Номенклатура")]
		public string Nomenklatura { get; set; } = "";
		[RecordInfo("Брутто")]
		public decimal Brutto { get; set; } = 0;
		[RecordInfo("Тара")]
		public decimal Tara { get; set; } = 0;
		[RecordInfo("Нетто")]
		public decimal Netto { get; set; } = 0;
		[RecordInfo("Цена за 1 тонну, руб. (без НДС)")]
		public decimal Price { get; set; } = 0;
		[RecordInfo("Сумма")]
		public decimal Summa { get; set; } = 0;


	}
}
