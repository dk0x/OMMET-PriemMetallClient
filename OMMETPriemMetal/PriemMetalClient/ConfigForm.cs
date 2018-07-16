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
			ComPortsComboBox.Items.Add("-");
			ComPortsComboBox.Items.AddRange(ports);

			BaudRateComboBox.Items.Clear();
			BaudRateComboBox.Items.AddRange(new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
			BaudRateComboBox.SelectedIndex = BaudRateComboBox.Items.IndexOf("9600");

			int index = 0;
			if (ConfigManager.configParams.ComPort != null)
			{
				index = ComPortsComboBox.Items.IndexOf(ConfigManager.configParams.ComPort);
				if (index == -1) index = ComPortsComboBox.Items.IndexOf("-");
			}
			ComPortsComboBox.SelectedIndex = index;
			BaudRateComboBox.SelectedIndex = BaudRateComboBox.Items.IndexOf(ConfigManager.configParams.BaudRate.ToString());

			DriverMethodRadioButton.Checked = ConfigManager.configParams.VesWorkMethod == VesWorkMethod.DRIVER;
			ComportMethodRadioButton.Checked = ConfigManager.configParams.VesWorkMethod == VesWorkMethod.COMPORT;
			if (Environment.OSVersion.Platform == PlatformID.Unix)
			{
				DriverMethodRadioButton.Enabled = false;
				DriverMethodRadioButton.Checked = false;
				ComportMethodRadioButton.Checked = true;
				ConfigManager.configParams.VesWorkMethod = VesWorkMethod.COMPORT;

			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			ConfigManager.configParams.ComPort = (string)ComPortsComboBox.SelectedItem;
			ConfigManager.configParams.BaudRate = int.Parse((string)BaudRateComboBox.SelectedItem);
			if (DriverMethodRadioButton.Checked) ConfigManager.configParams.VesWorkMethod = VesWorkMethod.DRIVER;
			if (ComportMethodRadioButton.Checked) ConfigManager.configParams.VesWorkMethod = VesWorkMethod.COMPORT;
			ConfigManager.Save();
			VesManager.SetWorkMethod(ConfigManager.configParams.VesWorkMethod, true);
			Close();
		}

		private void ComportMethodRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			ComPortGroupBox.Enabled = true;
		}

		private void DriverMethodRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			ComPortGroupBox.Enabled = false;
		}
	}
}
