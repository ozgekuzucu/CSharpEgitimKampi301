using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
	public partial class FrmLocation : Form
	{
		public FrmLocation()
		{
			InitializeComponent();
		}
		EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

		private void btnList_Click(object sender, EventArgs e)
		{
			var values = db.Location.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Location location = new Location();
			location.Capacity = byte.Parse(nudCapacity.Value.ToString());
			location.City = txtCity.Text;
			location.Country = txtCountry.Text;
			location.Price = decimal.Parse(txtPrice.Text);
			location.DayNight = txtDayNight.Text;
			location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
			db.Location.Add(location);
			db.SaveChanges();
			MessageBox.Show("Ekleme işlemi başarılı");
		}

		private void FrmLocation_Load(object sender, EventArgs e)
		{
			var values = db.Guide.Select(x => new
			{
				FullName = x.GuideName + " " + x.GuideSurname,
				x.GuideId
			}).ToList();
			cmbGuide.DisplayMember = "FullName";
			cmbGuide.ValueMember = "GuideId";
			cmbGuide.DataSource = values;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtLocationId.Text);
			var deletedValue = db.Location.Find(id);
			db.Location.Remove(deletedValue);
			db.SaveChanges();
			MessageBox.Show("Silme işlemi başarılı");


		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtLocationId.Text);
			var updateedValue = db.Location.Find(id);
			updateedValue.DayNight = txtDayNight.Text;
			updateedValue.Price = decimal.Parse(txtPrice.Text);
			updateedValue.Capacity=byte.Parse(nudCapacity.Value.ToString());
			updateedValue.City=txtCity.Text;
			updateedValue.Country=txtCountry.Text;
			updateedValue.GuideId=int.Parse(cmbGuide.SelectedValue.ToString());
			db.SaveChanges();
			MessageBox.Show("Güncelleme işlemi başarılı");
		}
	}
}
