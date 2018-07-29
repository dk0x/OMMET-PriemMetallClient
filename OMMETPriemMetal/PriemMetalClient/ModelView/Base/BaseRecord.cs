using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PriemMetalClient
{

	public class BaseRecord
	{
		//[Text("Номер записи")]
		public int Id { get; set; } = 0;
		//[Text("Уникальный идентификатор")]
		public Guid Guid { get; set; } = Guid.NewGuid();
	}
}
