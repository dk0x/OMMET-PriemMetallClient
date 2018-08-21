using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	public enum PSADocumentStepEnum
	{
		NOMERDATA,
		CONTRAGENT,
		TRANSPORT,
		VESLIST,
		BRUTTO,
		METALLCAT,
		ZASOR,
		TARA,
	}

	[RecordInfo("Приёмо-сдаточный акт")]
	public class PSADocument2 : BaseRecord
	{
		[RecordInfo("Стадия", ReadOnly = true)]
		public PSADocumentStepEnum Step { get; set; } = PSADocumentStepEnum.NOMERDATA;

		[RecordInfo("Номер документа", StringFormat = "D8")]
		public int Nomer { get; set; } = 0;

		[RecordInfo("От", DateTimeFormat = DateTimeFormat.ShortDate)]
		public DateTime Date { get; set; } = DateTime.Now;

		[RecordInfo("Отделение приема")]
		public Otdelenie Otdelenie { get; set; } = null;

		[RecordInfo("Тип контрагента", TableNoColumn = true)]
		public ContragentType ContragentType { get; set; } = ContragentType.FizLico;

		[RecordInfo("Контрагент: Физ. лицо")]
		public ContragentFizLico ContragentFizLico { get; set; } = null;

		[RecordInfo("Контрагент: Юр. лицо")]
		public ContragentUrLico ContragentUrLico { get; set; } = null;

		[RecordInfo("Транспорт")]
		public Transport Transport { get; set; } = null;

		//[RecordInfo("Список принятого металла")]
		public List<DocumentMetallVesPrice2> MetallVesPriceItems { get; set; } = new List<DocumentMetallVesPrice2>();

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

		public override string ToString() => $"ПСА №{Nomer.ToString("D8")} От {Date.ToShortDateString()} Сумма {Summa.ToString("C")}";
	}

}
	
