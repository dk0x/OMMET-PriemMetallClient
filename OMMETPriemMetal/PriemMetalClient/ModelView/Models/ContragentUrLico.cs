using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[RecordInfo("Юридическое лицо")]
	public class ContragentUrLico : BaseRecord
	{
		[RecordInfo("Наименование юридического лица")]
		public string Naimenovanie { get; set; } = "";
		[RecordInfo("ИНН")]
		public string Inn { get; set; } = "";
		[RecordInfo("КПП")]
		public string Kpp { get; set; } = "";
		[RecordInfo("Адрес юридического лица", TextMultilane = true)] 
		public string Adress { get; set; } = "";

		[RecordInfo("Номер договора")]
		public string NomerDogovora { get; set; } = "";
		[RecordInfo("Дата договора", DatetimeDateOnly = true)] 
		public DateTime DataDogovora { get; set; } = DateTime.Now;

		public override string ToShortString() => $"{Naimenovanie}";
	}

}
