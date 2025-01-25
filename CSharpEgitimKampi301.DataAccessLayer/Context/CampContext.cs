using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
	public class CampContext : DbContext
	{
		//veritabanına tablo olarak yansıyacak olan tüm sınıflar burada yer alacak 
        public DbSet<Category> Categories { get; set; }
		//Category ifadesi-->bizim c# tarafında kullanılacak olan sınıf ismi
		//Categories ifadesi-->sql e yansıyacak olan tablo ismi
		/*
		 bunun programlamadaki ismi pluralize:sınıfla tablo birbirinin içine girmesin,
		 bunlar birbirinden ayırt edilebilsin diye yalın halini c# tarafında çoğul hali
		 sql tarafında kullan diyor.		 
		 */
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Admin>Admins { get; set; }

    }
}
