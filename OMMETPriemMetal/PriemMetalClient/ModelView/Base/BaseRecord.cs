﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using LiteDB;

namespace PriemMetalClient
{

	public class BaseRecord
	{
		//[Text("Уникальный идентификатор")]
		[LiteDB.BsonId]
		public Guid Guid { get; set; } = Guid.NewGuid();
		public DateTime _Created { get; set; } = DateTime.Now;

		public virtual string ToString(bool full)
		{
			if (full)
			{
				string s = "";
				var props = this.GetType().GetProperties();
				foreach (var p in props)
				{
					s = s + RecordInfoAttribute.ToStringBasedOnRecordInfo(p.GetValue(this, null), p) + "; ";
					/*var pinfo = RecordInfoAttribute.GetPropertyRecordInfo(p);
					if (pinfo?.Text != null)
					{
						s = s + pinfo.Text + ": ";
						if (p.PropertyType == typeof(DateTime))
						{
							if (pinfo.DatetimeDateOnly) s = s + ((DateTime)p.GetValue(this, null)).ToShortDateString();
							if (pinfo.DatetimeTimeOnly) s = s + ((DateTime)p.GetValue(this, null)).ToShortTimeString();
						}
						else
						{
							s = s + p.GetValue(this, null).ToString();
						}
						s = s + "; ";
					}*/
				}
				return s;
			} else
			{
				return this.GetType().Name;
			}
		}

		public override string ToString() => ToString(false);

		public static void SetListViewDefaultColumns<TRecord>(ListView listView) where TRecord : BaseRecord
		{
			List<string> NewColumns = new List<string>();
			var props = typeof(TRecord).GetProperties();
			foreach (var p in props)
			{
				var propInfo = RecordInfoAttribute.GetPropertyRecordInfo(p);
				if (propInfo == null) continue;
				if (propInfo.TableNoColumn) continue;
				NewColumns.Add(p.Name);
			}
			SetListViewColumns<TRecord>(listView, NewColumns);
		}

		public static void SetListViewColumns<TRecord>(ListView listView, List<string> newColumns) where TRecord : BaseRecord
		{
			listView.Columns.Clear();
			listView.Columns.Add(new DBColumnHeader()
			{
				Text = "",
				PropertyInfo = null,
				Width = 0
			});

			var props = typeof(TRecord).GetProperties();

			foreach (var propName in newColumns)
			{
				var prop = props.FirstOrDefault(x => x.Name == propName);
				if (prop == null) continue;
				var propInfo = RecordInfoAttribute.GetPropertyRecordInfo(prop);
				if (propInfo == null) continue;
				if (propInfo.TableNoColumn) continue; // Flags.HasFlag(RecordInfoFlags.NOTABLECOLUMN)) continue;
				if (string.IsNullOrWhiteSpace(propInfo.Text)) continue;
				DBColumnHeader header = new DBColumnHeader()
				{
					Text = propInfo.Text,
					PropertyInfo = prop,
					Width = -2
				};
				if (prop.PropertyType == typeof(decimal)) header.TextAlign = HorizontalAlignment.Right;
				listView.Columns.Add(header);
				//listView.Columns.Add(propInfo.Text);
			}
			listView.Columns.Add(new DBColumnHeader()
			{
				Text = "",
				PropertyInfo = null,
				Width = -2
			});
		}
		public void UpsertListViewItem(ListView listView)
		{
			if (listView == null) return;
			DBListViewItem item = null;
			// search exist item in list
			foreach (DBListViewItem el in listView.Items)
				if (el.Record.Guid == Guid)
				{
					// found, break search
					item = el; 
					break;
				}
			if (item != null) // if item exist clear subitems 
			{
				item.SubItems.Clear();
			}
			else // if not exist create and add to listview
			{
				item = new DBListViewItem();
				listView.Items.Add(item);
				item.Record = this;
			}
			// fill substrings
			foreach (DBColumnHeader c in listView.Columns)
			{
				var prop = c.PropertyInfo;
				if (prop == null) continue;
				//var propInfo = RecordInfoAttribute.GetPropertyRecordInfo(prop);
				//if (propInfo == null) continue;
				//var value = prop.GetValue(record, null);
				string text = RecordInfoAttribute.ToStringBasedOnRecordInfo(prop.GetValue(this, null), prop);
				/*if (prop.PropertyType == typeof(decimal))
				{
					if (!string.IsNullOrWhiteSpace(propInfo.StringFormat))
						text = ((decimal)value).ToString(propInfo.StringFormat);
					else
						text = value.ToString();
				}
				else
				if (prop.PropertyType == typeof(DateTime))
				{
					
					if (propInfo.DatetimeDateOnly) text = ((DateTime)value).ToShortDateString();
					if (propInfo.DatetimeTimeOnly) text = ((DateTime)value).ToShortTimeString();
					if (!propInfo.DatetimeDateOnly && !propInfo.DatetimeTimeOnly) text = value.ToString();
				}
				else
					text = value?.ToString() ?? "";*/
				item.SubItems.Add(text);
				c.Width = -2;
			}
		}

	}
}
