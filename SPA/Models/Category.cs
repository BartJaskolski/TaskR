using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPA.Models
{
    public class Category
    {
        public int categoryID { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę Kategorii")]
        [StringLength(80)]
        public string categoryName { get; set; }
        [Required(ErrorMessage = "Wprowadź opis Kategorii")]
        [StringLength(80)]
        public string categoryDescription { get; set; }

        public virtual ICollection<Products> products { get; set; }
    }
}