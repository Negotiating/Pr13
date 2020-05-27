using System;
using System.Windows.Forms;

namespace PR13_WF
{
	public abstract class Goods
	{
		public abstract void info(DataGridViewRow row);
		public abstract bool valid();
	}
	public class Product : Goods
	{
		private string _name;
		private string _price;
		private DateTime _date_of_manufacture;
		private TimeSpan _expiration_date;
		public Product(string name, string price, DateTime date_of_manufacture, TimeSpan expiration_date)
		{
			_name = name;
			_price = price;
			_date_of_manufacture = date_of_manufacture;
			_expiration_date = expiration_date;
		}
		public override void info(DataGridViewRow row)
		{
			row.Cells["Name"].Value = _name;
			row.Cells["Price"].Value = _price;
			row.Cells["Date"].Value = _date_of_manufacture;
			row.Cells["Span"].Value = _expiration_date;
		}
		public override bool valid()
		{
			if (DateTime.Today - _date_of_manufacture < _expiration_date) return true;
			else return false;
		}
	}
	public class Consignment : Goods
	{
		private string _name;
		private string _price;
		private int _quantity;
		private DateTime _date_of_manufacture;
		private TimeSpan _expiration_date;
		public Consignment(string name, string price, int quantity, DateTime date_of_manufacture, TimeSpan expiration_date)
		{
			_name = name;
			_price = price;
			_quantity = quantity;
			_date_of_manufacture = date_of_manufacture;
			_expiration_date = expiration_date;
		}
		public override void info(DataGridViewRow row)
		{
			row.Cells["Name"].Value = _name;
			row.Cells["Price"].Value = _price;
			row.Cells["Quantity"].Value = _quantity;
			row.Cells["Date"].Value = _date_of_manufacture;
			row.Cells["Span"].Value = _expiration_date;
		}
		public override bool valid()
		{
			if (DateTime.Today - _date_of_manufacture < _expiration_date) return true;
			else return false;
		}
	}
	class Kit : Goods
	{
		private string _name;
		private string _price;
		private string _list;
		public Kit() { }
		public Kit(string name, string price, string list)
		{
			_name = name;
			_price = price;
			_list = list;
		}
		public override void info(DataGridViewRow row)
		{
			row.Cells["Name"].Value = _name;
			row.Cells["Price"].Value = _price;
			row.Cells["List"].Value = _list;
		}
		public override bool valid() => true;
	}
}
