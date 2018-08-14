using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[RecordInfo("Транспорт")]
	public class Transport : BaseRecord
	{
		[RecordInfo("Гос. номер", StringCase = StringCase.UpperCase)]
		public string GosNomer { get; set; } = string.Empty;
		[RecordInfo("Марка")]
		public string Marka { get; set; } = string.Empty;
		[RecordInfo("Модель")]
		public string Model { get; set; } = string.Empty;

		public override string ToString() => $"{Marka} {Model} {GosNomer}";
	}
}
