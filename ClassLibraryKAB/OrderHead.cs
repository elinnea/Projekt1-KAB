using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryKAB
{
    public class OrderHead
    {
        public int OrderHeadID { get; set; }
        public int CustomerID { get; set; }
        public decimal Discount { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatus { get; set; }

        public OrderHead(int orderHeadID, int customerID, decimal discount, string orderDate, string orderStatus)
        {
            OrderHeadID = orderHeadID;
            CustomerID = customerID;
            Discount = discount;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
    }
}
