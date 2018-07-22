using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	public static class DataBase
	{

		private static LiteDatabase _DB = null;
		public static LiteDatabase DB { get => GetDB(); }

		private static LiteDatabase GetDB()
		{
			if (_DB == null)
				_DB = new LiteDatabase(Tools.Path(ConfigManager.Parameters.DataBasePath));
			return _DB;
		}

		public static LiteCollection<BuyPriceMetall> BuyPriceMetallTable { get => DB.GetCollection<BuyPriceMetall>(); }
	}
}
