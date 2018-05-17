using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPA.Models
{
    public class Order
    {
        public int orderID { get; set; }
        [Required(ErrorMessage = "Podaj imię")]
        [StringLength(50)]
        public string name { get; set; }
        [Required(ErrorMessage = "Podaj Nazwisko")]
        [StringLength(80)]
        public string surname { get; set; }
        [Required(ErrorMessage = "Podaj ulicę")]
        [StringLength(100)]
        public string street { get; set; }
        [Required(ErrorMessage = "Podaj miasto")]
        [StringLength(100)]
        public string city { get; set; }
        [Required(ErrorMessage = "Podaj kod pocztowy")]
        [StringLength(6)]
        public string postalCode { get; set; } 
        public string numberPhone { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
        public DateTime dateOfOrder { get; set; }
        public OrderStatus orderStatus { get; set; }
        public decimal valueOfOrder { get; set; }

        List<PositionOfOrder> positionOfOrder { get; set; }
    }

    public enum OrderStatus
    {
        New,
        Done
    }
}
