using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
	public class Product
	{
        public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int	ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }//Her bir ürünün bir kategorisi var
        public virtual Category Category { get; set; }//Kategori tablosunun değerlerine ürün üzerinden ulaşabilmek adına eklendi
        public List<Order> Orders { get; set; }
        /*[NotMapped]
        public string CategoryName { get; set; }    */
    }
}
