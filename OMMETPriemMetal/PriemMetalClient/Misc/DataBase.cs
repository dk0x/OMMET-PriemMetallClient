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
		public static LiteRepository Repo { get => new LiteRepository(DB); }
		public static LiteCollection<PSADocument> PSADocumentCollection
		{
			get => DB.GetCollection<PSADocument>()/*.
				Include(x => x.ContragentFizLico).
				Include(x => x.ContragentUrLico).
				Include(x => x.Otdelenie).
				Include(x => x.Transport).
				Include(x => x.MetallVesPriceItems)*/;
		}
		public static LiteCollection<PSADocumentHistory> PSADocumentHistoryCollection
		{
			get => DB.GetCollection<PSADocumentHistory>()/*.
				Include(x => x.ContragentFizLico).
				Include(x => x.ContragentUrLico).
				Include(x => x.Otdelenie).
				Include(x => x.Transport).
				Include(x => x.MetallVesPriceItems)*/;
		}

		private static LiteDatabase GetDB()
		{
			if (_DB == null)
			{
				//_DB = new LiteDatabase(Tools.Path(ConfigManager.Parameters.DataBasePath));
				var connStr = new ConnectionString($"filename=\"{Tools.Path(ConfigManager.Parameters.DataBasePath)}\"; journal =false;");
				_DB = new LiteDatabase(connStr);
				/*BsonMapper.Global.Entity<PSADocument>().DbRef(x => x.Otdelenie);
				BsonMapper.Global.Entity<PSADocument>().DbRef(x => x.Transport);
				BsonMapper.Global.Entity<PSADocument>().DbRef(x => x.ContragentFizLico);
				BsonMapper.Global.Entity<PSADocument>().DbRef(x => x.ContragentUrLico);
				BsonMapper.Global.Entity<PSADocument>().DbRef(x => x.MetallVesPriceItems);*/
				//DropDB();
				FillTestData();
			}
			while (_DB.Engine.Locker.ThreadState != LockState.Unlocked) { System.Threading.Thread.Sleep(10); }
			return _DB;
		}

		private static void DropDB()
		{
			DB.DropCollection(typeof(ContragentFizLico).Name);
			DB.DropCollection(typeof(ContragentUrLico).Name);
			DB.DropCollection(typeof(MetallPrice).Name);
			DB.DropCollection(typeof(Otdelenie).Name);
			DB.DropCollection(typeof(PSADocument).Name);
			DB.DropCollection(typeof(DocumentMetallVesPrice).Name);
			DB.DropCollection(typeof(Transport).Name);
			DB.DropCollection(typeof(KassaTransaction).Name);
			DB.DropCollection(typeof(PSADocumentHistory).Name);
		}

		private static void FillTestData()
		{
			DropDB();
			Otdelenie otdelenie;
			{
				(otdelenie = new Otdelenie()
				{
					Adres = "г. Омск, ул. 22 Партсъезда, 105",
					Nazvanie = "ОП ВМР-Амурское",
					Telefon = "8-913-617-24-45"
				}).DBUpsert();
			}
			{
				(new MetallPrice()
				{
					Category = "3АН",
					Nomenklatura = "3АН Габаритный лом",
					Description = "Размеры куска должны быть НЕ более 800*500*500 мм. без ограничений по толщине. Не допускается проволока и изделия из проволоки.",
					Price = 11500
				}).DBUpsert();
				(new MetallPrice()
				{
					Category = "12А,5А",
					Nomenklatura = "12А,5А Негабаритный лом",
					Description = "Лом габаритами больше  800*500*500 мм. Допускается проволока и изделия из проволоки.",
					Price = 11200
				}).DBUpsert();
				(new MetallPrice()
				{
					Category = "16А",
					Nomenklatura = "16А",
					Description = "Вьютнообразная стальная стружка. Не допускается кусковые отходы и лом. Не должна быть смешанной с легированной стружкой и стружкой из цветных металлов.",
					Price = 3000
				}).DBUpsert();
				(new MetallPrice()
				{
					Category = "22А",
					Nomenklatura = "22А",
					Description = "Чугунные станки, узлы, детали и механизмы в собранном состоянии с содержанием стали не более 5% по массе.",
					Price = 6000
				}).DBUpsert();
			}
			Transport transport;
			{
				(transport = new Transport()
				{
					GosNomer = "К357РМ 55",
					Marka = "ГАЗ",
					Model = "3109"
				}).DBUpsert();
				(new Transport()
				{
					GosNomer = "У965НР 55",
					Marka = "УАЗ",
					Model = "ПАТРИОТ"
				}).DBUpsert();
				(new Transport()
				{
					GosNomer = "Е425МО 55",
					Marka = "УАЗ",
					Model = "БУХАНКА"
				}).DBUpsert();
			}
			ContragentFizLico contragentFizLico;
			{
				(contragentFizLico = new ContragentFizLico()
				{
					Familiya = "Иванов",
					Imja = "Иван",
					Otchestvo = "Иванович",
					SerijaNomerPasport = "55 695841",
					DataVidachiPasport = new DateTime(2008, 5, 8),
					AdresRegistraciiPasport = "ул. Пушкина, д. 5",
					MestoVidachiPasport = "УВД в ЦАО г. Омска"
				}).DBUpsert();
			}
			{
				(new PSADocument
				{
					ContragentFizLico = contragentFizLico,
					ContragentType = ContragentType.FizLico,
					Nomer = 564,
					Otdelenie = otdelenie,
					Transport = transport
				}).DBUpsert();
			}
			for (int i = 0; i < 100; i++)
			{
				Random rnd = new Random();
				int r = rnd.Next(0, i);
				(new Otdelenie
				{
					Adres = $"Adres {i}",
					Nazvanie = $"Nazvanie {i}",
					Telefon = $"Telefon {i}",
				}).DBUpsert();
				(new MetallPrice
				{
					Category = $"Category {i}",
					Nomenklatura = $"Nomenklatura {i}",
					Description = $"Description {i}",
					Price = i*100m
				}).DBUpsert();
				(new Transport
				{
					GosNomer = $"GosNomer {i}",
					Marka = $"Marka {i}",
					Model = $"Model {i}",
				}).DBUpsert();
				(new ContragentFizLico
				{
					Familiya = $"Familiya {i}",
					Imja = $"Imja {i}",
					Otchestvo = $"Otchestvo {i}",
					SerijaNomerPasport = $"SerijaNomerPasport {i}",
					DataVidachiPasport = new DateTime(2000 + r, 5, 8),
					AdresRegistraciiPasport = $"AdresRegistraciiPasport {i}",
					MestoVidachiPasport = $"MestoVidachiPasport {i}",
				}).DBUpsert();
				(new ContragentUrLico
				{
					Adress = $"Adress {i}",
					Inn = $"Inn {i}",
					Kpp = $"Kpp {i}",
					Naimenovanie = $"Naimenovanie {i}",
					NomerDogovora = $"NomerDogovora {i}",
					DataDogovora = new DateTime(2000 + r, 5, 8),
				}).DBUpsert();
				var fiz = DB.GetCollection<ContragentFizLico>().FindAll().ToList();
				var ur = DB.GetCollection<ContragentUrLico>().FindAll().ToList();
				var otd = DB.GetCollection<Otdelenie>().FindAll().ToList();
				var tr = DB.GetCollection<Transport>().FindAll().ToList();
				ContragentType t = rnd.Next(1, 100) > 50 ? ContragentType.FizLico : ContragentType.UrLico;
				(new PSADocument
				{
					ContragentFizLico = t == ContragentType.FizLico ? fiz[r] : null,
					ContragentUrLico = t == ContragentType.UrLico ? ur[r] : null,
					ContragentType = t,
					Nomer = i,
					Otdelenie = otd[r],
					Transport = tr[r]
				}).DBUpsert();
			}

		}
	}
}
