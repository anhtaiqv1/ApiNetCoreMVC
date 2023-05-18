using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.Catalog.ProductImages
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { set; get; }
        public int Stock { get; set; }
        public int ViewCout { get; set; }

        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
    }
}
