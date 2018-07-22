using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public class DBListViewItem: ListViewItem
	{
		public Guid Guid = Guid.Empty;
		public int Id = 0;
	}
}
