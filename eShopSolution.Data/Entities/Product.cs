using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.Data.Entities
{

    public class Product
    {
       
        public int Id { get; set; }
        public int Price { get; set; }
        public decimal OriginalPrice { get; set; }

        public int Stock { get; set; }
        public int  ViewCout { get; set; }
        public DateTime DateCreated  { get; set; }
       
        public string SeaoAlias { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { set; get; }
        public List<ProductTranslation> ProductTranslations { set; get; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
