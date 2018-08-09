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
	public partial class PSADocumentMetallForm : Form
	{
		public PSADocumentMetall Record { get; private set; } = null;
		public PSADocumentMetallForm()
		{
			InitializeComponent();
			metallPriceRecordSelectUserControl1.RecordSelect += MetallPriceRecordSelectUserControl1_RecordSelect;
		}

		private void MetallPriceRecordSelectUserControl1_RecordSelect(object sender, MetallPrice record)
		{
			if (record != null)
			{
				uslovija.Text = record.Description;
				cena.Value = record.Price;
			}
		}

		public new PSADocumentMetall ShowDialog(PSADocumentMetall rec, IWin32Window owner)
		{
			Record = rec;
			if (base.ShowDialog(owner) == DialogResult.OK)
			{
				return new PSADocumentMetall
				{
					Brutto = brutto.Value,
					Category = metallPriceRecordSelectUserControl1.Record.Category,
					Netto = netto.Value,
					Nomenklatura = metallPriceRecordSelectUserControl1.Record.Nomenklatura,
					Price = cena.Value,
					Summa = summa.Value,
					Tara = tara.Value,
					Zasor = zasor.Value,
				};
			}
			return null;
		}

		public void SetRecord(PSADocumentMetall rec)
		{

		}

		public void SaveRecord()
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			var v = VesManager.Report.AverageValue;
			VesValue.Value = v >= 0m ? v : 0m;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var v = VesManager.Report.AverageValue;
			brutto.Value = v >= 0m ? v : 0m;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var v = VesManager.Report.AverageValue;
			tara.Value = v >= 0m ? v : 0m;
		}

		private void brutto_ValueChanged(object sender, EventArgs e)
		{
			var val = brutto.Value - tara.Value;
			netto.Value = val >= 0m ? val : 0m;
		}

		private void netto_ValueChanged(object sender, EventArgs e)
		{
			var val = netto.Value * cena.Value * ((100m - zasor.Value) / 100m);
			summa.Value = val;
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
