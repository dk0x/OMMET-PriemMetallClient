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
		public static LiteCollection<PSADocument> PSADocumentCollection {
			get => DataBase.DB.GetCollection<PSADocument>().
				Include(x => x.ContragentFizLico).
				Include(x => x.ContragentUrLico).
				Include(x => x.Otdelenie).
				Include(x => x.Transport).
				Include(x => x.Metalls);
			}

		private static LiteDatabase GetDB()
		{
			if (_DB == null)
			{
				_DB = new LiteDatabase(Tools.Path(ConfigManager.Parameters.DataBasePath));
				//BsonMapper.Global.Entity<PSADocument>().DbRef(x => x.PSADocumentMetalls, "PSADocumentMetall");
				FillTestData();
			}
			return _DB;
		}

		private static void FillTestData()
		{
			DB.DropCollection(typeof(ContragentFizLico).Name);
			DB.DropCollection(typeof(ContragentUrLico).Name);
			DB.DropCollection(typeof(MetallPrice).Name);
			DB.DropCollection(typeof(Otdelenie).Name);
			DB.DropCollection(typeof(PSADocument).Name);
			DB.DropCollection(typeof(PSADocumentMetall).Name);
			DB.DropCollection(typeof(Transport).Name);
			{
				var con = DB.GetCollection<Otdelenie>();
				con.Upsert(new Otdelenie()
				{
					Adres = "г. Омскб, ул. 22 Партсъезда, 105",
					Nazvanie = "ОП ВМР-Амурское",
					Telefon = "8-913-617-24-45"
				});
			}
			{
				var con = DB.GetCollection<MetallPrice>();
				con.Upsert(new MetallPrice()
				{
					Category = "3АН",
					Nomenklatura = "3АН Габаритный лом",
					Description = "Размеры куска должны быть НЕ более 800*500*500 мм. без ограничений по толщине. Не допускается проволока и изделия из проволоки.",
					Price = 11500
				});
				con.Upsert(new MetallPrice()
				{
					Category = "12А,5А",
					Nomenklatura = "12А,5А Негабаритный лом",
					Description = "Лом габаритами больше  800*500*500 мм. Допускается проволока и изделия из проволоки.",
					Price = 11200
				});
				con.Upsert(new MetallPrice()
				{
					Category = "16А",
					Nomenklatura = "16А",
					Description = "Вьютнообразная стальная стружка. Не допускается кусковые отходы и лом. Не должна быть смешанной с легированной стружкой и стружкой из цветных металлов.",
					Price = 3000
				});
				con.Upsert(new MetallPrice()
				{
					Category = "22А",
					Nomenklatura = "22А",
					Description = "Чугунные станки, узлы, детали и механизмы в собранном состоянии с содержанием стали не более 5% по массе.",
					Price = 6000
				});
			}
			{
				var con = DB.GetCollection<Transport>();
				con.Upsert(new Transport()
				{
					GosNomer = "К357РМ 55",
					Marka = "ГАЗ",
					Model = "3109"
				});
				con.Upsert(new Transport()
				{
					GosNomer = "У965НР 55",
					Marka = "УАЗ",
					Model = "ПАТРИОТ"
				});
				con.Upsert(new Transport()
				{
					GosNomer = "Е425МО 55",
					Marka = "УАЗ",
					Model = "БУХАНКА"
				});
			}
			{
				var con = DB.GetCollection<ContragentFizLico>();
				con.Upsert(new ContragentFizLico()
				{
					Familiya = "Иванов",
					Imja = "Иван",
					Otchestvo = "Иванович",
					SerijaNomerPasport = "55 695841",
					DataVidachiPasport = new DateTime(2008, 5, 8),
					AdresRegistraciiPasport = "ул. Пушкина, д. 5",
					MestoVidachiPasport = "УВД в ЦАО г. Омска"
				});
			}
		}
	}
}
