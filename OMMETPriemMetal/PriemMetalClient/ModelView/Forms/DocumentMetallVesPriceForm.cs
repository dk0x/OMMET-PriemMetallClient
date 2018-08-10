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
	public partial class DocumentMetallVesPriceForm : Form
	{
		public DocumentMetallVesPrice Record { get; private set; } = null;
		public DocumentMetallVesPriceForm()
		{
			InitializeComponent();
		}

		public DocumentMetallVesPrice ShowDialogForEditMetalVesPrice(DocumentMetallVesPrice record, IWin32Window owner)
		{
			if (record == null) return null;
			SetRecord(record); // заполним поля формы записью
			this.ShowDialog(owner); // покажем форму как диалог
			SaveRecord(); // сохраним документ
			return record;
		}

		/*public new DocumentMetallVesPrice ShowDialog(DocumentMetallVesPrice rec, IWin32Window owner)
		{
			Record = rec;
			if (base.ShowDialog(owner) == DialogResult.OK)
			{
				SaveRecord();
				return Record;
			}
			return null;
		}*/

		public void SetRecord(DocumentMetallVesPrice rec)
		{
			Record = rec;

			zasor.Value = Record.Zasor;
			cena.Value = Record.Price;
			brutto.Value = Record.Brutto;
			tara.Value = Record.Tara;
			//netto.Value = Record.Netto;
			//summa.Value = Record.Summa;
			categorija.Text = Record.Category;
			uslovija.Text = Record.Description;
			nomenklatura.Text = Record.Nomenklatura;
		}

		public void SaveRecord()
		{
			Record.Brutto = brutto.Value;
			Record.Description = uslovija.Text;
			Record.Category = categorija.Text;
			Record.Netto = netto.Value;
			Record.Nomenklatura = nomenklatura.Text;
			Record.Price = cena.Value;
			Record.Summa = summa.Value;
			Record.Tara = tara.Value;
			Record.Zasor = zasor.Value;
			DataBase.DB.GetCollection<DocumentMetallVesPrice>().Upsert(Record);
		}

		private void Timer1_Tick(object sender, EventArgs e)
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

		private void MetallSelect_Click(object sender, EventArgs e)
		{
			using (var f = new BaseRecordBookForm<MetallPrice>())
			{
				var m = f.ShowDialogSelect(this);
				if (m != null)
				{
					categorija.Text = m.Category;
					uslovija.Text = m.Description;
					nomenklatura.Text = m.Nomenklatura;
					cena.Value = m.Price;
				}
			}
		}
	}
}
