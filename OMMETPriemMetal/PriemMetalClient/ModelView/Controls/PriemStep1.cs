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
		private DocumentMetallVesPrice2 _CurrentMetal = null;
		public DocumentMetallVesPrice2 CurrentMetal {
			get => GetCurrentMetall();
			private set => _CurrentMetal = value;
		}

		public PriemStep1()
		{
			InitializeComponent();
			SetDocument(new PSADocument2());
		}

		public void SetDocument(PSADocument2 doc)
		{
			Document = doc;
			RefreshTitle();
			SetStep(doc.Step);
		}

		public DocumentMetallVesPrice2 GetCurrentMetall()
		{
			if (Document == null) return null;
			if (_CurrentMetal == null)
			{
				_CurrentMetal = Document.MetallVesPriceItems.LastOrDefault();
				if (_CurrentMetal == null)
					Document.MetallVesPriceItems.Add(_CurrentMetal = new DocumentMetallVesPrice2());
			}
			return _CurrentMetal;
		}

		public void DBUpsert()
		{
			if (Document == null) return;
			Document.DBUpsert();
		}

		public void RefreshTitle()
		{
			if (Document == null) return;
			docNoLabel.Text = $"Приемо-сдаточный акт №{Document.Nomer} от {Document.Date.ToShortDateString()}";
		}

		public void SetStep(PSADocumentStepEnum step)
		{
			if (Document == null) return;
			NomerDataStepPanel.Visible = false;
			ContragentStepPanel.Visible = false;
			TransportStepPanel.Visible = false;
			VesListStepPanel.Visible = false;
			VesBruttoStepPanel.Visible = false;
			MetallCatStepPanel.Visible = false;
			ZasorStepPanel.Visible = false;
			VesTaraStepPanel.Visible = false;
			switch (step)
			{
				case PSADocumentStepEnum.NOMERDATA:
					{
						nomer.Text = Document.Nomer.ToString("D8");
						data.Value = Document.Date;
						NomerDataStepPanel.Visible = true;
					}
					break;
				case PSADocumentStepEnum.CONTRAGENT:
					{
						ContragentStepPanel.Visible = true;
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
					}
					break;
				case PSADocumentStepEnum.TRANSPORT:
					{
						TransportStepPanel.Visible = true;
						transport.SetRecord(Document.Transport);
					}
					break;
				case PSADocumentStepEnum.VESLIST:
					{
						VesList.Items.Clear();
						VesList.Items.AddRange(Document.MetallVesPriceItems.ToArray());
						VesListStepPanel.Visible = true;
					}
					break;
				case PSADocumentStepEnum.BRUTTO:
					{
						VesBruttoStepPanel.Visible = true;
						bruttoTextBox.Text = CurrentMetal.Brutto != 0 ?
							$"{CurrentMetal.Brutto.ToString("N3")} тонн ({CurrentMetal.BruttoInputMethod.ToFriendlyString()})" :
							"Не взвешано";
					}
					break;
				case PSADocumentStepEnum.METALLCAT:
					{
						MetallCatStepPanel.Visible = true;
						metallCat.SetRecord(CurrentMetal.Category);
					}
					break;
				case PSADocumentStepEnum.ZASOR:
					{
						ZasorStepPanel.Visible = true;
						zasor.Value = CurrentMetal.Zasor;
					}
					break;
				case PSADocumentStepEnum.TARA:
					{
						VesTaraStepPanel.Visible = true;
						taraTextBox.Text = CurrentMetal.Tara != 0 ?
							$"{CurrentMetal.Tara.ToString("N3")} тонн ({CurrentMetal.TaraInputMethod.ToFriendlyString()})" :
							"Не указано";
					}
					break;
				default:
					break;
			}
			Document.Step = step;
		}

		public void RefreshStep()
		{
			if (Document == null) return;
			SetStep(Document.Step);
		}

		private void FizUrSelect_CheckedChanged(object sender, EventArgs e)
		{
			contragentFizLico.Visible = false;
			contragentUrLico.Visible = false;
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

		private void ContragentStepBtn_Click(object sender, EventArgs e)
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
					ContragentStepAlarmLabel.Text = "Контрагент не выбран!";
				} else
				{
					ContragentStepAlarmLabel.Text = "";
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
				CurrentMetal.Brutto = f.Result.AverageValue;
				CurrentMetal.BruttoInputMethod = VesInputMethod.HARDWARE;
				RefreshStep();
				DBUpsert();
			}
		}

		private void VesBruttoCustomBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			var f = new NumericInputDialogForm();
			if (f.ShowDialog("Введите вес вручную", 3, this) == DialogResult.OK)
			{
				CurrentMetal.Brutto = f.Result;
				CurrentMetal.BruttoInputMethod = VesInputMethod.CUSTOM;
				RefreshStep();
				DBUpsert();
			}
		}

		private void TransportStepNextBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			bool good = false;
			{
				good = Document.Transport != null;

				if (!good)
				{
					TransportStepAlarmLabel.Text = "Транспорт не выбран!";
				}
				else
				{
					TransportStepAlarmLabel.Text = "";
					SetStep(PSADocumentStepEnum.VESLIST);
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

		private void VesListStepNextBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			{
				if (Document.MetallVesPriceItems.Count == 0)
				{
					VesListStepAlarmLabel.Text = "Список пуст. Призведите взвешивание! ";
				}
				else
				{
					VesListStepAlarmLabel.Text = "";
					SetStep(PSADocumentStepEnum.NOMERDATA);
					DBUpsert();
				}
			}
		}

		private void metallCat_RecordSelect(object sender, MetallPrice record)
		{
			if (Document == null) return;
			CurrentMetal.Category = record;
			DBUpsert();
		}

		private void VesBruttoStepNextBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			bool good = false;
			{
				good = CurrentMetal.Brutto > 0;

				if (!good)
				{
					VesBruttoStepAlarmLabel.Text = "Введите вес БРУТТО!";
				}
				else
				{
					VesBruttoStepAlarmLabel.Text = "";
					SetStep(PSADocumentStepEnum.METALLCAT);
					DBUpsert();
				}
			}
		}

		private void zasor_ValueChanged(object sender, EventArgs e)
		{
			if (Document == null) return;
			CurrentMetal.Zasor = zasor.Value;
			DBUpsert();
		}

		private void ZasorStepNextBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			CurrentMetal.Zasor = zasor.Value;
			SetStep(PSADocumentStepEnum.TARA);
			DBUpsert();
		}

		private void VesTaraDialogBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			var f = new VesDialogForm();
			if (f.ShowDialog(this) == DialogResult.OK)
			{
				CurrentMetal.Tara = f.Result.AverageValue;
				CurrentMetal.TaraInputMethod = VesInputMethod.HARDWARE;
				RefreshStep();
				DBUpsert();
			}
		}

		private void VesTaraCustomBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			var f = new NumericInputDialogForm();
			if (f.ShowDialog("Введите вес вручную", 3, this) == DialogResult.OK)
			{
				CurrentMetal.Tara = f.Result;
				CurrentMetal.TaraInputMethod = VesInputMethod.CUSTOM;
				RefreshStep();
				DBUpsert();
			}
		}

		private void NomerDataStepNextBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			DBUpsert();
			SetStep(PSADocumentStepEnum.CONTRAGENT);
		}

		private void nomer_TextChanged(object sender, EventArgs e)
		{
			Document.Nomer = Convert.ToInt32(nomer.Text);
			RefreshTitle();
		}

		private void data_ValueChanged(object sender, EventArgs e)
		{
			Document.Date = data.Value;
			RefreshTitle();
		}

		private void VesTaraStepNextBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			bool good = false;
			{
				good = CurrentMetal.Tara > 0;

				if (!good)
				{
					VesTaraStepAlarmLabel.Text = "Введите вес ТАРЫ!";
				}
				else
				{
					CurrentMetal.Netto = CurrentMetal.Brutto - CurrentMetal.Tara;
					CurrentMetal.Netto *= (100m - CurrentMetal.Zasor) / 100m;
					CurrentMetal.Summa = CurrentMetal.Netto * CurrentMetal.Category.Price;
					VesTaraStepAlarmLabel.Text = "";
					SetStep(PSADocumentStepEnum.VESLIST);
					DBUpsert();
				}
			}
		}

		private void VesListStepAddBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			Document.MetallVesPriceItems.Add(CurrentMetal = new DocumentMetallVesPrice2());
			SetStep(PSADocumentStepEnum.BRUTTO);
		}

		private void MetallCatStepNextBtn_Click(object sender, EventArgs e)
		{
			if (Document == null) return;
			bool good = false;
			{
				good = CurrentMetal.Category != null;

				if (!good)
				{
					MetallCatStepAlarmLabel.Text = "Категория металла не выбрана!";
				}
				else
				{
					MetallCatStepAlarmLabel.Text = "";
					SetStep(PSADocumentStepEnum.ZASOR);
					DBUpsert();
				}
			}
		}

		private void VesListStepEditBtn_Click(object sender, EventArgs e)
		{
			if (VesList.SelectedItem != null)
			{
				if (Document == null) return;
				CurrentMetal = VesList.SelectedItem as DocumentMetallVesPrice2;
				SetStep(PSADocumentStepEnum.BRUTTO);
			}
		}

		private void VesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			VesListStepEditBtn.Enabled = VesList.SelectedIndex >= 0;
			VesListStepDeleteBtn.Enabled = VesList.SelectedIndex >= 0;
		}
	}
}
