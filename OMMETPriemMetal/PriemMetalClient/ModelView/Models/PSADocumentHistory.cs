using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	[Serializable]
	public class PSADocumentHistory : PSADocument
	{
		public Guid PSADocumentGuid { get; set; } = Guid.Empty;
		[RecordInfo("Причина редактирования", TextMultilane = true)]
		public string Prichina { get; set; } = string.Empty;
		[RecordInfo("Дата и время редактирования")]
		public DateTime DataVremya { get; set; } = DateTime.Now;



	}
}
