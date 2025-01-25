namespace CSharpEgitimKampi301.PresentationLayer
{
	partial class FrmCategory
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rdbActive = new System.Windows.Forms.RadioButton();
			this.rdbPasive = new System.Windows.Forms.RadioButton();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnGetById = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kategori ID:";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(175, 47);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(214, 30);
			this.txtCategoryId.TabIndex = 1;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(175, 214);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(214, 53);
			this.btnList.TabIndex = 2;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(414, 47);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(643, 469);
			this.dataGridView1.TabIndex = 3;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(175, 96);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(214, 30);
			this.txtCategoryName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kategori Adı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Kategori Durum:";
			// 
			// rdbActive
			// 
			this.rdbActive.AutoSize = true;
			this.rdbActive.Location = new System.Drawing.Point(175, 145);
			this.rdbActive.Name = "rdbActive";
			this.rdbActive.Size = new System.Drawing.Size(71, 29);
			this.rdbActive.TabIndex = 8;
			this.rdbActive.TabStop = true;
			this.rdbActive.Text = "Aktif";
			this.rdbActive.UseVisualStyleBackColor = true;
			// 
			// rdbPasive
			// 
			this.rdbPasive.AutoSize = true;
			this.rdbPasive.Location = new System.Drawing.Point(271, 145);
			this.rdbPasive.Name = "rdbPasive";
			this.rdbPasive.Size = new System.Drawing.Size(76, 29);
			this.rdbPasive.TabIndex = 9;
			this.rdbPasive.TabStop = true;
			this.rdbPasive.Text = "Pasif";
			this.rdbPasive.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(175, 277);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(214, 53);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(175, 340);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(214, 53);
			this.btnDelete.TabIndex = 11;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(175, 402);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(214, 53);
			this.btnUpdate.TabIndex = 12;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(175, 463);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(214, 53);
			this.btnGetById.TabIndex = 13;
			this.btnGetById.Text = "ID\'ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = true;
			this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
			// 
			// FrmCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1091, 552);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.rdbPasive);
			this.Controls.Add(this.rdbActive);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmCategory";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdbActive;
		private System.Windows.Forms.RadioButton rdbPasive;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnGetById;
	}
}

