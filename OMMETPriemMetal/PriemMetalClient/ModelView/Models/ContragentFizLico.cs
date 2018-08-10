using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[RecordInfo("Физическое лицо")]
	public class ContragentFizLico : BaseRecord
	{
		[RecordInfo("Фамилия")]
		public string Familiya { get; set; } = "";
		[RecordInfo("Имя")]
		public string Imja { get; set; } = "";
		[RecordInfo("Отчество")]
		public string Otchestvo { get; set; } = "";

		[RecordInfo("Серия, номер паспорта")]
		public string SerijaNomerPasport { get; set; } = "";
		[RecordInfo("Дата выдачи", DateTimeFormat = DateTimeFormat.ShortDate)] 
		public DateTime DataVidachiPasport { get; set; } = DateTime.Now;
		[RecordInfo("Место выдачи", TextMultilane = true)] 
		public string MestoVidachiPasport { get; set; } = "";
		[RecordInfo("Адрес регистрации", TextMultilane = true)] 
		public string AdresRegistraciiPasport { get; set; } = "";

		public override string ToString() => $"{Familiya} {Imja} {Otchestvo}";

	}
}
