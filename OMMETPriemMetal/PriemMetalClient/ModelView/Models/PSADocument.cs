using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	public enum ContragentType
	{
		FizLico,
		UrLico
	}
	[RecordInfo("Приёмо-сдаточный акт")]
	public class PSADocument : BaseRecord
	{
		[RecordInfo("Номер документа", StringFormat = "D8")]
		public int Nomer { get; set; } = 0;

		[RecordInfo("От", DateTimeFormat = DateTimeFormat.ShortDate)]
		public DateTime Date { get; set; } = DateTime.Now;

		[RecordInfo("Отделение приема")]
		//[LiteDB.BsonRef()]
		public Otdelenie Otdelenie { get; set; } = null;

		[RecordInfo("Тип контрагента", TableNoColumn = true)]
		public ContragentType ContragentType { get; set; } = ContragentType.FizLico;

		[RecordInfo("Контрагент: Физ. лицо")]
		//[LiteDB.BsonRef()]
		public ContragentFizLico ContragentFizLico { get; set; } = null;

		[RecordInfo("Контрагент: Юр. лицо")]
		//[LiteDB.BsonRef()]
		public ContragentUrLico ContragentUrLico { get; set; } = null;

		[RecordInfo("Транспорт")]
		//[LiteDB.BsonRef()]
		public Transport Transport { get; set; } = null;

		[RecordInfo("Описание лома", TableNoColumn = true)]
		public string OpisanieLoma { get; set; } = string.Empty;

		[RecordInfo("Основание", TableNoColumn = true)]
		public string Osnovanie { get; set; } = string.Empty;

		[RecordInfo("Нетто", StringFormat = "N3", DecimalDigits = 3)]
		public decimal Netto { get; set; } = 0;

		[RecordInfo("Сумма", StringFormat = "C", DecimalDigits = 2)]
		public decimal Summa { get; set; } = 0;

		[RecordInfo("Цена без НДС")]
		public bool BezNds { get; set; } = true;

		[RecordInfo("Проведен")]
		public bool Proveden { get; set; } = false;

		public override string ToString() => $"ПСА-{Nomer} От {Date.ToShortDateString()} Сумма {Summa.ToString("C")}";


		//[RecordInfo("Список принятого металла")]
		//[LiteDB.BsonRef]
		public List<DocumentMetallVesPrice> MetallVesPriceItems { get; set; } = new List<DocumentMetallVesPrice>();
	}

}
	
