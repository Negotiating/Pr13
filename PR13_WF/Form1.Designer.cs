namespace PR13_WF
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.off_button = new System.Windows.Forms.Button();
			this.not_valiad_button = new System.Windows.Forms.Button();
			this.product_tabel = new System.Windows.Forms.DataGridView();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Span = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.List = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.product_tabel)).BeginInit();
			this.SuspendLayout();
			// 
			// off_button
			// 
			this.off_button.Location = new System.Drawing.Point(420, 12);
			this.off_button.Name = "off_button";
			this.off_button.Size = new System.Drawing.Size(163, 35);
			this.off_button.TabIndex = 5;
			this.off_button.Text = "Сбросить";
			this.off_button.UseVisualStyleBackColor = true;
			this.off_button.Click += new System.EventHandler(this.off_button_Click);
			// 
			// not_valiad_button
			// 
			this.not_valiad_button.Location = new System.Drawing.Point(12, 12);
			this.not_valiad_button.Name = "not_valiad_button";
			this.not_valiad_button.Size = new System.Drawing.Size(402, 35);
			this.not_valiad_button.TabIndex = 4;
			this.not_valiad_button.Text = "Показать товары с истекшим сроком годности";
			this.not_valiad_button.UseVisualStyleBackColor = true;
			this.not_valiad_button.Click += new System.EventHandler(this.not_valiad_button_Click);
			// 
			// product_tabel
			// 
			this.product_tabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.product_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.product_tabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price,
            this.Date,
            this.Span,
            this.Quantity,
            this.List});
			this.product_tabel.Location = new System.Drawing.Point(12, 53);
			this.product_tabel.Name = "product_tabel";
			this.product_tabel.RowTemplate.Height = 24;
			this.product_tabel.Size = new System.Drawing.Size(943, 173);
			this.product_tabel.TabIndex = 3;
			// 
			// Name
			// 
			this.Name.HeaderText = "Название";
			this.Name.Name = "Name";
			this.Name.Width = 101;
			// 
			// Price
			// 
			this.Price.HeaderText = "Цена";
			this.Price.Name = "Price";
			this.Price.Width = 72;
			// 
			// Date
			// 
			this.Date.HeaderText = "Дата производства";
			this.Date.Name = "Date";
			this.Date.Width = 152;
			// 
			// Span
			// 
			this.Span.HeaderText = "Срок годности";
			this.Span.Name = "Span";
			this.Span.Width = 121;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Количество";
			this.Quantity.Name = "Quantity";
			this.Quantity.Width = 115;
			// 
			// List
			// 
			this.List.HeaderText = "Перечень продуктов";
			this.List.Name = "List";
			this.List.Width = 159;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 246);
			this.Controls.Add(this.off_button);
			this.Controls.Add(this.not_valiad_button);
			this.Controls.Add(this.product_tabel);
			this.Text = "Практика 13";
			((System.ComponentModel.ISupportInitialize)(this.product_tabel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button off_button;
		private System.Windows.Forms.Button not_valiad_button;
		private System.Windows.Forms.DataGridView product_tabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn Span;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn List;
	}
}

