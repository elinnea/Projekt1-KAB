using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryKAB
{
    public class OrderDetail
    {
        public int OrderDetailsID { get; set; }
        public int OrderHeadID { get; set; }
        public int ArticleID { get; set; }
        public decimal Price { get; set; }
        public int NumberOfArticles { get; set; }

        public OrderDetail(int orderDetailsID, int orderHeadID, int articleID, decimal price, int numberOfArticles)
        {
            OrderDetailsID = orderDetailsID;
            OrderHeadID = orderHeadID;
            ArticleID = articleID;
            Price = price;
            NumberOfArticles = numberOfArticles;

        }

        public OrderDetail(int orderHeadID, int articleID, decimal price, int numberOfArticles)
        {
            OrderHeadID = orderHeadID;
            ArticleID = articleID;
            Price = price;
            NumberOfArticles = numberOfArticles;
        }
    }


}
