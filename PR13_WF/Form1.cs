using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PR13_WF
{
	public partial class Form1 : Form
	{
		List<Goods> product_list = new List<Goods>();
		private void fill_tabel(DataGridView tabel, List<Goods> list)
		{
			tabel.RowCount = list.Count;
			for (int i = 0; i < tabel.RowCount; i++)
			{
				list[i].info(tabel.Rows[i]);
			}
		}
		public Form1()
		{
			InitializeComponent();
			try
			{
				string path = @"C:\Users\User\Desktop\Goods.txt";
				string[] all_lines = File.ReadAllLines(path);
				for (int i = 0; i < all_lines.Length; i++)
				{
					string[] position = all_lines[i].Split(';');
					if (position.Length == 4)
					{
						TimeSpan span = new TimeSpan(Convert.ToInt32(position[3]), 0, 0, 0);
						Product product = new Product(position[0].ToString(), position[1].ToString(), Convert.ToDateTime(position[2]), span);
						product_list.Add(product);
					}
					else
					{
						if (position.Length == 5)
						{
							TimeSpan span = new TimeSpan(Convert.ToInt32(position[4]), 0, 0, 0);
							Consignment consignment = new Consignment(position[0], position[1], Convert.ToInt32(position[2]), Convert.ToDateTime(position[3]), span);
							product_list.Add(consignment);
						}
						if (position.Length == 3)
						{
							Kit kit = new Kit(position[0], position[1], position[2]);
							product_list.Add(kit);
						}
					}
				}
				fill_tabel(product_tabel, product_list);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
			
		}

		private void not_valiad_button_Click(object sender, EventArgs e)
		{
			try
			{
				List<Goods> not_valid = new List<Goods>();
				int count = 0;
				foreach (Goods var in product_list)
				{
					if (!var.valid()) count++;
				}
				if (count != 0)
				{
					foreach (Goods var in product_list)
					{
						if (!var.valid()) not_valid.Add(var);
					}
					fill_tabel(product_tabel, not_valid);
				}
				else MessageBox.Show("Просроченных товаров нет");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void off_button_Click(object sender, EventArgs e)
		{
			fill_tabel(product_tabel, product_list);
		}
	}
}
