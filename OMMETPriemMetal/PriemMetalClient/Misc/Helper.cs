using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	public static class Helper
	{
		public static bool IsNullOrWhiteSpace(this string s) => String.IsNullOrWhiteSpace(s);
		public static string ToFriendlyString(this PriceType me)
		{
			switch (me)
			{
				case PriceType.PRICELIST: return "По прайсу";
				case PriceType.DOGOVOR: return "По договору";
				case PriceType.PERSONAL: return "Персональная";
			}
			return "";
		}
		public static string ToFriendlyString(this VesWorkMethod me)
		{
			switch (me)
			{
				case VesWorkMethod.DRIVER: return "Драйвер";
				case VesWorkMethod.COMPORT: return "Без драйвера";
			}
			return "";
		}
		public static string ToFriendlyString(this VesInputMethod me)
		{
			switch (me)
			{
				case VesInputMethod.HARDWARE: return "Взвешено";
				case VesInputMethod.CUSTOM: return "Введено вручную";
			}
			return "";
		}
	}
}
