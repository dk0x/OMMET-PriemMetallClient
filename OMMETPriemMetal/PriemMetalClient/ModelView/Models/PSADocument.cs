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
	public class PSADocument : BaseRecord
	{
		[RecordInfo("Номер документа")]
		public int Nomer { get; set; } = 0;

		[RecordInfo("От")]
		public DateTime Date { get; set; } = DateTime.Now;

		[RecordInfo("Отделение приема")]
		[LiteDB.BsonRef("Otdelenie")]
		public Otdelenie Otdelenie { get; set; } = null;

		[RecordInfo("Тип контрагента")]
		public ContragentType ContragentType { get; set; } = ContragentType.FizLico;

		[RecordInfo("Контрагент: Физ. лицо")]
		[LiteDB.BsonRef("ContragentFizLico")]
		public ContragentFizLico ContragentFizLico { get; set; } = null;

		[RecordInfo("Контрагент: Юр. лицо")]
		[LiteDB.BsonRef("ContragentUrLico")]
		public ContragentUrLico ContragentUrLico { get; set; } = null;

		[RecordInfo("Транспорт")]
		[LiteDB.BsonRef("Transport")]
		public Transport Transport { get; set; } = null;

		[RecordInfo("Описание лома")]
		public string OpisanieLoma { get; set; } = string.Empty;

		[RecordInfo("Основание")]
		public string Osnovanie { get; set; } = string.Empty;

		[RecordInfo("Нетто", StringFormat = "N3")]
		public decimal Netto { get; set; } = 0;

		[RecordInfo("Сумма", StringFormat = "C")]
		public decimal Summa { get; set; } = 0;

		[RecordInfo("Цена без НДС")]
		public bool Nds { get; set; } = false;



		[RecordInfo("Список принятого металла")]
		//[LiteDB.BsonIgnore]
		[LiteDB.BsonRef("PSADocumentMetall")]
		public List<PSADocumentMetall> Metalls { get; set; }
		/*{
			get => DataBase.DB.GetCollection<PSADocumentMetall>().Find(x => x.PSADocumentGuid == Guid).ToList();
		}*/
	}

}
	
