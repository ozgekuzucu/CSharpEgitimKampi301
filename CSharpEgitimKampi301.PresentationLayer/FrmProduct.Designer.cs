namespace CSharpEgitimKampi301.PresentationLayer
{
	partial class FrmProduct
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGetById = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.btnList2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(157, 662);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(214, 53);
			this.btnGetById.TabIndex = 26;
			this.btnGetById.Text = "ID\'ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = true;
			this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(157, 601);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(214, 53);
			this.btnUpdate.TabIndex = 25;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(157, 539);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(214, 53);
			this.btnDelete.TabIndex = 24;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(157, 476);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(214, 53);
			this.btnAdd.TabIndex = 23;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(157, 105);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(214, 30);
			this.txtProductName.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 25);
			this.label2.TabIndex = 18;
			this.label2.Text = "Ürün Adı:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(396, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(846, 659);
			this.dataGridView1.TabIndex = 17;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(157, 413);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(99, 53);
			this.btnList.TabIndex = 16;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(157, 56);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(214, 30);
			this.txtProductId.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Ürün ID:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(157, 201);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(214, 30);
			this.txtProductPrice.TabIndex = 30;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 25);
			this.label4.TabIndex = 29;
			this.label4.Text = "Ürün Fiyat:";
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(157, 152);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(214, 30);
			this.txtProductStock.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(46, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 25);
			this.label5.TabIndex = 27;
			this.label5.Text = "Ürün Stok:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(157, 299);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(214, 81);
			this.txtDescription.TabIndex = 34;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(53, 302);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 25);
			this.label6.TabIndex = 33;
			this.label6.Text = "Açıklama:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(60, 253);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 25);
			this.label7.TabIndex = 31;
			this.label7.Text = "Kategori:";
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(157, 253);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(214, 33);
			this.cmbCategory.TabIndex = 35;
			// 
			// btnList2
			// 
			this.btnList2.Location = new System.Drawing.Point(272, 413);
			this.btnList2.Name = "btnList2";
			this.btnList2.Size = new System.Drawing.Size(99, 53);
			this.btnList2.TabIndex = 36;
			this.btnList2.Text = "Listele 2";
			this.btnList2.UseVisualStyleBackColor = true;
			this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(221)))));
			this.ClientSize = new System.Drawing.Size(1282, 745);
			this.Controls.Add(this.btnList2);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmProduct";
			this.Text = "FrmProduct";
			this.Load += new System.EventHandler(this.FrmProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Button btnList2;
	}
}