using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace PriemMetalClient
{
	public partial class ConfigForm : Form
	{
		public ConfigForm()
		{
			InitializeComponent();
		}

		private void ConfigForm_Load(object sender, EventArgs e)
		{

		}

		private void ConfigForm_Shown(object sender, EventArgs e)
		{
			string[] ports = SerialPort.GetPortNames();
			ComPortsComboBox.Items.Clear();
			ComPortsComboBox.Items.AddRange(ports);

			ComPortsComboBox.SelectedIndex = ComPortsComboBox.Items.IndexOf(ConfigManager.configParams.ComPort);
			BaudRateComboBox.SelectedIndex = BaudRateComboBox.Items.IndexOf(ConfigManager.configParams.BaudRate.ToString());
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			ConfigManager.configParams.ComPort = (string)ComPortsComboBox.SelectedItem;
			ConfigManager.configParams.BaudRate = int.Parse((string)BaudRateComboBox.SelectedItem);
			ConfigManager.Save();
			Close();

		}
	}
}
