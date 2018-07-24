using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	/*public struct ListViewColumn
	{
		public string ColumnCaption;
		public string Property;
	}*/
	public class ListViewItem<T> : ListViewItem where T : BaseRecord
	{
		public Guid Guid { get => Record.Guid; set { Record.Guid = value; } }
		public int Id { get => Record.Id; set { Record.Id = value; } }
		public T Record = default(T);
	}
	public class ListViewItemBaseRecord : ListViewItem
	{
		public BaseRecord Record = default(BaseRecord);
	}
}
