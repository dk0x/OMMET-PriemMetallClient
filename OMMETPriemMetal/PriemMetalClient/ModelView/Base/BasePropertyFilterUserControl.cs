using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public class BasePropertyFilterUserControl : UserControl
	{
		public PropertyInfo Property { get; private set; } = null;
		public List<Type> SupportTypes = new List<Type>();

		public virtual bool SetProperty(PropertyInfo prop)
		{
			if (prop == null) return false;
			if (!(SupportTypes.Contains(prop.PropertyType))) return false;
			Property = prop;
			return true;
		}

		public virtual Query GetQueryFilter()
		{
			return Query.All();
		}
	}
}
