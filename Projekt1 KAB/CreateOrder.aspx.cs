using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using ClassLibraryKAB;

namespace Projekt1_KAB
{
    public partial class OrderHead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] != null)
            {
                List<Article> cart = ((List<Article>)Session["Cart"]);

                Customer user = ((Customer)Session["user"]);

                int customerID = user.CustomerID;
                decimal discount = 0;
                string orderDate = DateTime.Today.ToString();
                string orderStatus = "Pågående";

                int orderHeadID = ClassLibraryKAB.SQL.CreateOrderHead(customerID, discount, orderDate, orderStatus);

                foreach (var item in cart)
                {
                    int articleID = item.ArticleID;
                    decimal price = item.ArticlePrice;
                    int numberOfArticles = 1;
                   
                    ClassLibraryKAB.SQL.CreateOrderDetail(orderHeadID, articleID, price, numberOfArticles);
                }

                
            }
        }
    }
}