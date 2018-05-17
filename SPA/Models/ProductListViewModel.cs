using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA.Models
{
    public class ProductListViewModel
    {
        public int productsID { get; set; }
        public int categoryID { get; set; }
        public string productName { get; set; }
        public string productDesctription { get; set; }
        public decimal productsPrice { get; set; }
    }
}