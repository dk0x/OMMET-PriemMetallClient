using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[RecordInfo("Прием партии металлолома")]
	public class PSADocumentMetall : BaseRecord
	{
		public Guid PSADocumentGuid { get; set; } = Guid.Empty;
		[RecordInfo("Категория металла")]
		public string Category { get; set; } = null;
		[RecordInfo("Номенклатура")]
		public string Nomenklatura { get; set; } = "";
		[RecordInfo("Брутто", StringFormat = "N3", DecimalDigits = 3, VesValueInsertButton = true)]
		public decimal Brutto { get; set; } = 0;
		[RecordInfo("Тара", StringFormat = "N3", DecimalDigits = 3, VesValueInsertButton = true)]
		public decimal Tara { get; set; } = 0;
		[RecordInfo("Нетто", StringFormat = "N3", DecimalDigits = 3)]
		public decimal Netto { get; set; } = 0;
		[RecordInfo("% засора")]
		public decimal Zasor { get; set; } = 0;
		[RecordInfo("Цена за 1 тонну, руб.(без НДС)", StringFormat = "C", DecimalDigits = 2)]
		public decimal Price { get; set; } = 0;
		[RecordInfo("Сумма", StringFormat = "C", DecimalDigits = 2)]
		public decimal Summa { get; set; } = 0;


	}
}
