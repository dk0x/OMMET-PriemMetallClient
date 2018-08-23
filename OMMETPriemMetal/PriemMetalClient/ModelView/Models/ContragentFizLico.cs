using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[RecordInfo("Физическое лицо")]
	public class ContragentFizLico : BaseRecord
	{
		[RecordInfo("Серия, номер паспорта", TextMask = "00 00 000000")]
		public string SerijaNomerPasport { get; set; } = string.Empty;

		[RecordInfo("Фамилия")]
		public string Familiya { get; set; } = string.Empty;
		[RecordInfo("Имя")]
		public string Imja { get; set; } = string.Empty;
		[RecordInfo("Отчество")]
		public string Otchestvo { get; set; } = string.Empty;

		[RecordInfo("Дата выдачи", DateTimeFormat = DateTimeFormat.ShortDate, 
			TableNoColumn = true, TableNoFilter = true)] 
		public DateTime DataVidachiPasport { get; set; } = DateTime.Now;
		[RecordInfo("Место выдачи", TextMultilane = true,
			TableNoColumn = true, TableNoFilter = true)] 
		public string MestoVidachiPasport { get; set; } = string.Empty;
		[RecordInfo("Адрес регистрации", TextMultilane = true,
			TableNoColumn = true, TableNoFilter = true)] 
		public string AdresRegistraciiPasport { get; set; } = string.Empty;

		public override string ToString() => $"{SerijaNomerPasport} {Familiya} {Imja} {Otchestvo}";

	}
}
