using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient.ModelView.Controls
{
	public partial class PriemStep1 : UserControl
	{
		public PSADocument2 Document { get; private set; } = new PSADocument2();
		public PriemStep1()
		{
			InitializeComponent();
			Document = new PSADocument2();
			RefreshViewValues();
			ShowStep(Document.Step);
		}

		public void SetDocument(PSADocument2 doc)
		{
			Document = doc;
			RefreshViewValues();
			ShowStep(doc.Step);
		}

		public void DBUpsert()
		{
			if (Document == null) return;
			Document.DBUpsert();
		}

		public void RefreshViewValues()
		{
			if (Document == null) return;
			docNoLabel.Text = $"Приемо-сдаточный акт №{Document.Nomer} от {Document.Date.ToShortDateString()}";
			switch (Document.ContragentType)
			{
				case ContragentType.FizLico:
					FizSelect.Checked = true;
					contragentFizLico.SetRecord(Document.ContragentFizLico);
					break;
				case ContragentType.UrLico:
					UrSelect.Checked = true;
					contragentUrLico.SetRecord(Document.ContragentUrLico);
					break;
				default:
					break;
			}
			transport.SetRecord(Document.Transport);
			var v = Document.MetallVesPriceItems.LastOrDefault();
			if (v != null)
			{
				bruttoTextBox.Text = v.Brutto != 0 ? 
					$"{v.Brutto.ToString("N3")} тонн ({v.BruttoInputMethod.ToFriendlyString()})" :
					"Не указано";
				metallCat.SetRecord(v.Category);
				taraTextBox.Text = v.Tara != 0 ?
					$"{v.Tara.ToString("N3")} тонн ({v.TaraInputMethod.ToFriendlyString()})" :
					"Не указано";
			}
			else
			{
				bruttoTextBox.Text = "Не указано";
				taraTextBox.Text = "Не указано";
			}

		}

		public void SetStep(PSADocumentStepEnum step)
		{
			if (Document == null) return;
			Document.Step = step;
			ShowStep(step);
		}

		public void ShowStep(PSADocumentStepEnum step)
		{
			Step1ContragentPanel.Visible = step == PSADocumentStepEnum.CONTRAGENT;
			Step2TransportPanel.Visible = step == PSADocumentStepEnum.TRANSPORT;
			Step3VesBruttoPanel.Visible = step == PSADocumentStepEnum.BRUTTO;
			Step4MetallCatPanel.Visible = step == PSADocumentStepEnum.METALLCAT;
			Step5ZasorPanel.Visible = step == PSADocumentStepEnum.ZASOR;
			Step6TaraPanel.Visible = step == PSADocumentStepEnum.TARA;
		}

		private void FizUrSelect_CheckedChanged(object sender, EventArgs e)
		{
			contragentFizLico.Visible = FizSelect.Checked;
			contragentUrLico.Visible = UrSelect.Checked;
			if (Document == null) return;
			Document.ContragentType = FizSelect.Checked ? ContragentType.FizLico : ContragentType.UrLico;
			DBUpsert();
		}

		private void contragentFizLico_RecordSelect(object sender, ContragentFizLico record)
		{
			if (Document == null) return;
			Document.ContragentFizLico = record;
			Document.ContragentUrLico = null;
			DBUpsert();
		}

		private void contragentUrLico_RecordSelect(object sender, ContragentUrLico record)
		{
			if (Document == null) return;
			Document.ContragentFizLico = null;
			Document.ContragentUrLico = record;
			DBUpsert();
		}

		private void Next1Btn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			bool good = false;
			{
				switch (Document.ContragentType)
				{
					case ContragentType.FizLico:
						good = Document.ContragentFizLico != null;
						break;
					case ContragentType.UrLico:
						good = Document.ContragentUrLico != null;
						break;
					default:
						break;
				}
				if (!good)
				{
					alarm1Label.Text = "Контрагент не выбран!";
				} else
				{
					alarm1Label.Text = "";
					Document.MetallVesPriceItems.Add(new DocumentMetallVesPrice2());
					SetStep(PSADocumentStepEnum.TRANSPORT);
					DBUpsert();
				}
			}
		}

		private void VesBruttoDialogBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			var f = new VesDialogForm();
			if (f.ShowDialog(this) == DialogResult.OK)
			{
				var v = Document.MetallVesPriceItems.LastOrDefault();
				if (v == null) Document.MetallVesPriceItems.Add(v = new DocumentMetallVesPrice2());
				v.Brutto = f.Result.AverageValue;
				v.BruttoInputMethod = VesInputMethod.HARDWARE;
				RefreshViewValues();
				DBUpsert();
			}
		}

		private void VesBruttoCustomBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			var f = new NumericInputDialogForm();
			if (f.ShowDialog("Введите вес вручную", 3, this) == DialogResult.OK)
			{
				var v = Document.MetallVesPriceItems.LastOrDefault();
				if (v == null) Document.MetallVesPriceItems.Add(v = new DocumentMetallVesPrice2());
				v.Brutto = f.Result;
				v.BruttoInputMethod = VesInputMethod.CUSTOM;
				RefreshViewValues();
				DBUpsert();
			}
		}

		private void Next2Btn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			bool good = false;
			{
				good = Document.Transport != null;

				if (!good)
				{
					alarm2Label.Text = "Транспорт не выбран!";
				}
				else
				{
					alarm2Label.Text = "";
					SetStep(PSADocumentStepEnum.BRUTTO);
					DBUpsert();
				}
			}

		}

		private void transport_RecordSelect(object sender, Transport record)
		{
			if (Document == null) return;
			Document.Transport = record;
			DBUpsert();
		}

		private void Next3Btn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			bool good = false;
			{
				var v = Document.MetallVesPriceItems.LastOrDefault();
				if (v != null)
				{
					good = v.Brutto > 0;

					if (!good)
					{
						alarm3Label.Text = "Введите вес БРУТТО!";
					}
					else
					{
						alarm3Label.Text = "";
						SetStep(PSADocumentStepEnum.METALLCAT);
						DBUpsert();
					}
				}
			}
		}

		private void metallCat_RecordSelect(object sender, MetallPrice record)
		{
			if (Document == null) return;
			var v = Document.MetallVesPriceItems.LastOrDefault();
			if (v == null) Document.MetallVesPriceItems.Add(v = new DocumentMetallVesPrice2());
			v.Category = record;
			DBUpsert();
		}

		private void Next4Btn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			bool good = false;
			{
				var v = Document.MetallVesPriceItems.LastOrDefault();
				if (v != null)
				{
					good = v.Category != null;

					if (!good)
					{
						alarm3Label.Text = "Категория металла не выбрана!";
					}
					else
					{
						alarm3Label.Text = "";
						SetStep(PSADocumentStepEnum.ZASOR);
						DBUpsert();
					}
				}
			}
		}

		private void zasor_ValueChanged(object sender, EventArgs e)
		{
			if (Document == null) return;
			var v = Document.MetallVesPriceItems.LastOrDefault();
			if (v == null) Document.MetallVesPriceItems.Add(v = new DocumentMetallVesPrice2());
			v.Zasor = zasor.Value;
			DBUpsert();
		}

		private void Next5Btn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			SetStep(PSADocumentStepEnum.TARA);
			DBUpsert();
		}

		private void VesTaraDialogBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			var f = new VesDialogForm();
			if (f.ShowDialog(this) == DialogResult.OK)
			{
				var v = Document.MetallVesPriceItems.LastOrDefault();
				if (v == null) Document.MetallVesPriceItems.Add(v = new DocumentMetallVesPrice2());
				v.Tara = f.Result.AverageValue;
				v.TaraInputMethod = VesInputMethod.HARDWARE;
				RefreshViewValues();
				DBUpsert();
			}
		}

		private void VesTaraCustomBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			var f = new NumericInputDialogForm();
			if (f.ShowDialog("Введите вес вручную", 3, this) == DialogResult.OK)
			{
				var v = Document.MetallVesPriceItems.LastOrDefault();
				if (v == null) Document.MetallVesPriceItems.Add(v = new DocumentMetallVesPrice2());
				v.Tara = f.Result;
				v.TaraInputMethod = VesInputMethod.CUSTOM;
				RefreshViewValues();
				DBUpsert();
			}
		}
	}
}
