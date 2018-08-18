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
		public PSADocumentStep DocumentStep { get; private set; } = new PSADocumentStep();
		public PriemStep1()
		{
			InitializeComponent();
			DocumentStep = new PSADocumentStep();
			DocumentStep.Document = new PSADocument();
			UpdateActualControlValues();
		}

		public void SetDocumentStep(PSADocumentStep docStep)
		{
			DocumentStep = docStep;
			UpdateActualControlValues();
		}

		public void DBUpsert()
		{
			if (DocumentStep == null) return;
			DocumentStep.DBUpsert();
		}

		public void UpdateActualControlValues()
		{
			var doc = DocumentStep?.Document;
			if (doc == null) return;
			docNoLabel.Text = $"Приемо сдаточный акт №{doc.Nomer} от {doc.Date.ToShortDateString()}";
			switch (DocumentStep.Document.ContragentType)
			{
				case ContragentType.FizLico:
					FizSelect.Checked = true;
					contragentFizLicoRecordSelectUserControl1.SetRecord(DocumentStep.Document.ContragentFizLico);
					break;
				case ContragentType.UrLico:
					UrSelect.Checked = true;
					contragentUrLicoRecordSelectUserControl1.SetRecord(DocumentStep.Document.ContragentUrLico);
					break;
				default:
					break;
			}
			transportRecordSelectUserControl1.SetRecord(DocumentStep.Document.Transport);
			UpdateActualStep();
		}

		public void UpdateActualStep()
		{
			if (DocumentStep == null) return;
			Step1ContragentPanel.Visible = DocumentStep.Step == PSADocumentStepEnum.CONTRAGENT;
			Step2TransportPanel.Visible = DocumentStep.Step == PSADocumentStepEnum.TRANSPORT;
		}

		private void FizUrSelect_CheckedChanged(object sender, EventArgs e)
		{
			contragentFizLicoRecordSelectUserControl1.Visible = FizSelect.Checked;
			contragentUrLicoRecordSelectUserControl1.Visible = UrSelect.Checked;
			if (DocumentStep.Document == null) return;
			DocumentStep.Document.ContragentType = FizSelect.Checked ? ContragentType.FizLico : ContragentType.UrLico;
			DBUpsert();
		}

		private void contragentFizLicoRecordSelectUserControl1_RecordSelect(object sender, ContragentFizLico record)
		{
			if (DocumentStep.Document == null) return;
			DocumentStep.Document.ContragentFizLico = record;
			DocumentStep.Document.ContragentUrLico = null;
			DBUpsert();
		}

		private void contragentUrLicoRecordSelectUserControl1_RecordSelect(object sender, ContragentUrLico record)
		{
			if (DocumentStep.Document == null) return;
			DocumentStep.Document.ContragentFizLico = null;
			DocumentStep.Document.ContragentUrLico = record;
			DBUpsert();
		}

		private void NextBtn_Click(object sender, EventArgs e)
		{
			bool good = false;
			if (DocumentStep.Step == PSADocumentStepEnum.CONTRAGENT)
			{
				switch (DocumentStep.Document.ContragentType)
				{
					case ContragentType.FizLico:
						good = DocumentStep.Document.ContragentFizLico != null;
						break;
					case ContragentType.UrLico:
						good = DocumentStep.Document.ContragentUrLico != null;
						break;
					default:
						break;
				}
				if (!good)
				{
					alarmLabel.Text = "Контрагент не выбран!";
				} else
				{
					alarmLabel.Text = "";
					DocumentStep.Step = PSADocumentStepEnum.TRANSPORT;
					UpdateActualStep();
				}
			}
		}
	}
}
