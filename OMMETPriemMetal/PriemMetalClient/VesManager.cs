using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevNet;

namespace PriemMetalClient
{
	public enum VesWorkMethod
	{
		DRIVER, COMPORT, FILE
	}
	public class VesData
	{
		public bool Stable = false;
		public double Value = 0;
	}
	public static class VesManager
	{
		public static VesWorkMethod VesWorkMethod = VesWorkMethod.DRIVER;
		private static dynamic DevNet = null;
		public static VesData Data { get { return GetData(); } }
		private static VesData data = new VesData();
		public static VesData GetData()
		{
			if (VesWorkMethod == VesWorkMethod.DRIVER)
			{
				data = GetDataFromDriver();
				if (data != null) return data;
				VesWorkMethod = VesWorkMethod.COMPORT;
			}
			if (VesWorkMethod == VesWorkMethod.COMPORT)
			{

			}
				return data;
		}
		public static VesData GetDataFromDriver()
		{
			VesData d = new VesData();
			if (DevNet == null)
			{
				try
				{
					DevNet = Activator.CreateInstance(Type.GetTypeFromProgID("DevNet.Drv"), false);
				}
				catch
				{
					DevNet = null;
					return null;
				}
			}
			try
			{
				double ves = 0;
				byte ErrState, Flags0, Flags1, DFlags, DState;
				DevNet.GetWeight(1, 0, out ves, out ErrState, out Flags0, out Flags1, out DFlags, out DState);
				d.Value = ves;
				d.Stable = true;
				return d;
			}
			catch
			{
				DevNet = null;
				return null;
			}

			
			return null;
		}
	}
}
