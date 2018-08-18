using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	public enum PSADocumentStepEnum
	{
		CONTRAGENT,
		TRANSPORT
	}
	public class PSADocumentStep : BaseRecord
	{
		[RecordInfo("Стадия")]
		public PSADocumentStepEnum Step { get; set; } = PSADocumentStepEnum.CONTRAGENT;
		[RecordInfo("Документ")]
		public PSADocument Document { get; set; } = default(PSADocument);
	}
}
