﻿namespace CSharpEgitimKampi301.EFProject
{
	partial class FrmLocation
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtLocationId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDayNight = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.nudCapacity = new System.Windows.Forms.NumericUpDown();
			this.cmbGuide = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnUpdate.Location = new System.Drawing.Point(190, 524);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(213, 43);
			this.btnUpdate.TabIndex = 22;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnDelete.Location = new System.Drawing.Point(190, 471);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(213, 43);
			this.btnDelete.TabIndex = 21;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAdd.Location = new System.Drawing.Point(190, 418);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(213, 43);
			this.btnAdd.TabIndex = 20;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(191, 135);
			this.txtCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(212, 30);
			this.txtCountry.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(135, 135);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 25);
			this.label3.TabIndex = 18;
			this.label3.Text = "Ülke:";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(191, 92);
			this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(212, 30);
			this.txtCity.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(128, 92);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 25);
			this.label2.TabIndex = 16;
			this.label2.Text = "Şehir:";
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnList.Location = new System.Drawing.Point(190, 365);
			this.btnList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(213, 43);
			this.btnList.TabIndex = 15;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(423, 48);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(626, 386);
			this.dataGridView1.TabIndex = 14;
			// 
			// txtLocationId
			// 
			this.txtLocationId.Location = new System.Drawing.Point(191, 48);
			this.txtLocationId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtLocationId.Name = "txtLocationId";
			this.txtLocationId.Size = new System.Drawing.Size(212, 30);
			this.txtLocationId.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(65, 48);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 25);
			this.label1.TabIndex = 12;
			this.label1.Text = "Lokasyon ID:";
			// 
			// txtDayNight
			// 
			this.txtDayNight.Location = new System.Drawing.Point(191, 262);
			this.txtDayNight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDayNight.Name = "txtDayNight";
			this.txtDayNight.Size = new System.Drawing.Size(212, 30);
			this.txtDayNight.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(83, 262);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 25);
			this.label4.TabIndex = 28;
			this.label4.Text = "Gün-Gece:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(191, 219);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(212, 30);
			this.txtPrice.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(132, 219);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 25);
			this.label5.TabIndex = 26;
			this.label5.Text = "Fiyat:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(97, 175);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 25);
			this.label6.TabIndex = 24;
			this.label6.Text = "Kapasite:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(111, 302);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 25);
			this.label7.TabIndex = 30;
			this.label7.Text = "Rehber:";
			// 
			// nudCapacity
			// 
			this.nudCapacity.Location = new System.Drawing.Point(191, 177);
			this.nudCapacity.Name = "nudCapacity";
			this.nudCapacity.Size = new System.Drawing.Size(212, 30);
			this.nudCapacity.TabIndex = 32;
			// 
			// cmbGuide
			// 
			this.cmbGuide.FormattingEnabled = true;
			this.cmbGuide.Location = new System.Drawing.Point(191, 302);
			this.cmbGuide.Name = "cmbGuide";
			this.cmbGuide.Size = new System.Drawing.Size(212, 33);
			this.cmbGuide.TabIndex = 33;
			// 
			// FrmLocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 635);
			this.Controls.Add(this.cmbGuide);
			this.Controls.Add(this.nudCapacity);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtDayNight);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtLocationId);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmLocation";
			this.Text = "FrmLocation";
			this.Load += new System.EventHandler(this.FrmLocation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtLocationId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDayNight;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nudCapacity;
		private System.Windows.Forms.ComboBox cmbGuide;
	}
}