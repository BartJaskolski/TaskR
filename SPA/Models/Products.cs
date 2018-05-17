using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SPA.Models
{ 
    public class Products
    {
        public int productsID { get; set; }
        public int categoryID { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę Produktu")]
        [StringLength(80)]
        public string productName { get; set; }
        [Required(ErrorMessage = "Wprowadź opis Produktu")]
        [StringLength(300)]
        public string productDesctription { get; set; }
        public decimal priceProduct { get; set; }
        public bool productAvailable { get; set; }
        public int minOrder { get; set; }
        public DateTime minTimeSupply { get; set; }

        public virtual Category Category { get; set; }
    }
}
