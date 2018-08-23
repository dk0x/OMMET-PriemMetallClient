﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[RecordInfo("Юридическое лицо")]
	public class ContragentUrLico : BaseRecord
	{
		[RecordInfo("ИНН", TextMask = "0000000000")]
		public string Inn { get; set; } = string.Empty;
		[RecordInfo("Наименование юридического лица")]
		public string Naimenovanie { get; set; } = string.Empty;
		[RecordInfo("КПП", TextMask = "000000000")]
		public string Kpp { get; set; } = string.Empty;
		[RecordInfo("Адрес юридического лица", TextMultilane = true)] 
		public string Adress { get; set; } = string.Empty;

		[RecordInfo("Номер договора")]
		public string NomerDogovora { get; set; } = string.Empty;
		[RecordInfo("Дата договора", DateTimeFormat = DateTimeFormat.ShortDate)] 
		public DateTime DataDogovora { get; set; } = DateTime.Now;

		public override string ToString() => $"{Inn} {Naimenovanie}";
	}

}
