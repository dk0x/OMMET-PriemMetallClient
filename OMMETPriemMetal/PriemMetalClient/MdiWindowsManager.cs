using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public static class MdiWindowsManager
	{
		private static UserControl Container = null;
		private static Form ParentMdiForm = null;
		private static List<Form> Forms = new List<Form>();
		public static void Init(Form parentMdiForm, UserControl container)
		{
			ParentMdiForm = parentMdiForm;
			Container = container;
		}

		/*public static Form CreateForm<T>(string name) where T : Form
		{
			Form exist = GetFormByName(name);
			if (exist == null)
			{
				Form newForm = new T();
			} else
			{
				exist.Show();
				return exist;
			}
		}*/

		public static Form GetFormByName(string name)
		{
			foreach (Form f in Forms)
				if (f.Text == name)
					return f;
			return null;
		}
	}
}
