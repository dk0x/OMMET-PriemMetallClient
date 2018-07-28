using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public partial class BuyPriceMetallBookForm : BaseBookForm<BuyPriceMetall>
	{
		public BuyPriceMetallBookForm()
		{
			InitializeComponent();
		}

		/*public override Form CreateEditForm(BuyPriceMetall record)
		{
			BuyPriceMetallEditForm editForm = new BuyPriceMetallEditForm();
			editForm.SetRecord(record);
			editForm.FormClosedSave += EditForm_FormClosedSave;
			return editForm;
		}*/
	}
}
