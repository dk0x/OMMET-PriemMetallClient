using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[RecordInfo("Служба, подразделение")]
	public class Otdelenie: BaseRecord
	{
		[RecordInfo("Название")]
		public string Nazvanie { get; set; } = "";
		[RecordInfo("Адрес")]
		public string Adres { get; set; } = "";
		[RecordInfo("Телефон")]
		public string Telefon { get; set; } = "";
	}

}
