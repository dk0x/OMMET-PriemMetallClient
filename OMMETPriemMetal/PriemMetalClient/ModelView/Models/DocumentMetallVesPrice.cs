﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriemMetalClient
{
	public enum PriceType
	{
		PRICELIST, DOGOVOR, PERSONAL
	}
	public enum VesInputMethod
	{
		HARDWARE, CUSTOM
	}

	[RecordInfo("Прием партии металлолома")]
	public class DocumentMetallVesPrice : BaseRecord
	{
		//public Guid OwnerDocumentGuid { get; set; } = Guid.Empty;
		[RecordInfo("Категория лома")]
		public string Category { get; set; } = string.Empty;
		[RecordInfo("Номенклатура")]
		public string Nomenklatura { get; set; } = string.Empty;
		[RecordInfo("Условия поставки", TextMultilane = true, TableNoColumn = true, TableNoFilter = true)]
		public string Description { get; set; } = string.Empty;
		[RecordInfo("Брутто", ToStringFormat = "N3", DecimalDigits = 3, VesValueInsertButton = true)]
		public decimal Brutto { get; set; } = 0;
		public VesInputMethod BruttoInputMethod { get; set; } = VesInputMethod.HARDWARE;
		[RecordInfo("Тара", ToStringFormat = "N3", DecimalDigits = 3, VesValueInsertButton = true)]
		public decimal Tara { get; set; } = 0;
		public VesInputMethod TaraInputMethod { get; set; } = VesInputMethod.HARDWARE;
		[RecordInfo("Нетто", ToStringFormat = "N3", DecimalDigits = 3)]
		public decimal Netto { get; set; } = 0;
		[RecordInfo("% засора")]
		public decimal Zasor { get; set; } = 0;
		[RecordInfo("Тип цены", TableNoColumn = true)]
		public PriceType PriceType { get; set; } = PriceType.PRICELIST;
		[RecordInfo("Цена за 1 тонну, руб.(без НДС)", ToStringFormat = "C", DecimalDigits = 2)]
		public decimal Price { get; set; } = 0;
		[RecordInfo("Сумма", ToStringFormat = "C", DecimalDigits = 2)]
		public decimal Summa { get; set; } = 0;

		public override string ToString() => $"{Category} Вес: {Netto.ToString("N3")} т. Стоимость: {Summa.ToString("C")}";
	}
}
