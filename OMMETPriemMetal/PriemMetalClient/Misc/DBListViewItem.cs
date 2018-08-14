using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	/*public struct ListViewColumn
	{
		public string ColumnCaption;
		public string Property;
	}*/
	public class DBColumnHeader : ColumnHeader
	{
		public PropertyInfo PropertyInfo { get; set; } = null;
		public RecordInfoAttribute InfoAttribute { get; set; } = null;
	}
	public class DBListViewItem : ListViewItem
	{
		public BaseRecord Record = default(BaseRecord);
	}
	/*public class ListViewItemBaseRecord : ListViewItem
	{
		public BaseRecord Record = default(BaseRecord);
	}*/
}
