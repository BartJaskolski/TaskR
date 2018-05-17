using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA.Models
{
    public class PositionOfOrder
    {
        public int positionOfOrderID { get; set; }
        public int orderID { get; set; }
        public int productID { get; set; }
        public int count { get; set; }
        public decimal valueOfPurchase { get; set; }

        public virtual Products product { get; set; }
        public virtual Order order { get; set; }
    }
}