using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public class BaseFilterUserControl : UserControl
	{
		public virtual Query GetQueryFilter()
		{
			return Query.All();
		}

	}
}
