using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[RecordInfo("Прием партии металлолома")]
	public class DocumentMetallVesPrice2 : BaseRecord
	{
		//public Guid OwnerDocumentGuid { get; set; } = Guid.Empty;
		[RecordInfo("Категория")]
		public MetallPrice Category { get; set; } = default(MetallPrice);
		[RecordInfo("Брутто", ToStringFormat = "N3", DecimalDigits = 3, VesValueInsertButton = true)]
		public decimal Brutto { get; set; } = 0;
		public VesInputMethod BruttoInputMethod { get; set; } = VesInputMethod.HARDWARE;
		[RecordInfo("Тара", ToStringFormat = "N3", DecimalDigits = 3, VesValueInsertButton = true)]
		public decimal Tara { get; set; } = 0;
		public VesInputMethod TaraInputMethod { get; set; } = VesInputMethod.HARDWARE;
		[RecordInfo("Нетто", ToStringFormat = "N3", DecimalDigits = 3)]
		public decimal Netto { get; set; } = 0;
		[RecordInfo("% засора")]
		public decimal Zasor { get; set; } = 0;
		[RecordInfo("Тип цены", TableNoColumn = true)]
		public PriceType PriceType { get; set; } = PriceType.PRICELIST;
		[RecordInfo("Цена", ToStringFormat = "C", DecimalDigits = 2)]
		public decimal Price { get; set; } = 0;
		[RecordInfo("Сумма", ToStringFormat = "C", DecimalDigits = 2)]
		public decimal Summa { get; set; } = 0;

		public override string ToString() => $"{Category?.Category??"-"} Вес: {Netto.ToString("N3")} т. Сумма: {Summa.ToString("C")}";
	}
}
