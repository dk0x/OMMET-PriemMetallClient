using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	public enum Osnovanie
	{
		NONE, PSADocument, Postuplenie
	}
	public static class OsnovanieExtensions
	{
		public static string ToFriendlyString(this Osnovanie me, BaseRecord rec = null)
		{
			switch (me)
			{
				case Osnovanie.NONE: return "Не указано";
				case Osnovanie.Postuplenie: return "Поступление";
				case Osnovanie.PSADocument: return rec?.ToString() ?? "Приемо-сдаточный акт";
			}
			return "";
		}
	}
	public class Kassa: BaseRecord
	{
		[RecordInfo("Основание")]
		public Osnovanie Osnovanie { get; set; } = Osnovanie.NONE;

		[RecordInfo("Приёмо-сдаточный акт")]
		[LiteDB.BsonRef()]
		public PSADocument PSADocument { get; set; } = default(PSADocument);


		[RecordInfo("Дебет", StringFormat = "C", DecimalDigits = 2)]
		public decimal Debet { get; set; } = 0;
		[RecordInfo("Кредит", StringFormat = "C", DecimalDigits = 2)]
		public decimal Credit { get; set; } = 0;


		public override string ToString() => $"Основание: {Osnovanie.ToFriendlyString(PSADocument)}; Дебет: {Debet.ToString("C")}; Кредит: {Credit.ToString("C")};";
	}
}
