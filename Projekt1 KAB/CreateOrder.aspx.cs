using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using ClassLibraryKAB;
using System.Globalization;

namespace Projekt1_KAB
{
    public partial class CreateOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] != null)
            {
                Literal1.Text = "Din order är mottagen och produkter samt faktura kommer att skickas till angiven adress. Tack för att du valt att handla hos Kontorsprylar KAB!";
                // Hämtar varukorgen med alla artiklar och gör en lista
                List<Article> cart = ((List<Article>)Session["Cart"]);

                // Hämtar inloggad kund
                Customer user = ((Customer)Session["user"]);

                // Detta skickas till databasen
                int customerID = user.CustomerID;
                decimal discount = 0;
                string orderDate = DateTime.Today.ToShortDateString();
                string orderStatus = "Pågående";



                int numberOfArticles = 1;

                // Skapar orderhuvud
                int orderHeadID = ClassLibraryKAB.SQL.CreateOrderHead(customerID, discount, orderDate, orderStatus);

                // Skapar order detlajer, en för varje artikel som har köpts
                foreach (var item in cart)
                {
                    int articleID = item.ArticleID;
                    decimal price = item.ArticlePrice;
                    int numberOA = numberOfArticles;

                    ClassLibraryKAB.SQL.CreateOrderDetail(orderHeadID, articleID, price, numberOA);
                }

                // Visa data för kunden Orderhuvud
                string htmlOH = "";
                decimal totalPrice = (Convert.ToDecimal(Session["totalPrice"]));

                htmlOH += "<table class=\"table table-hover\"><thead><tr><th>Din order</th><th>Rabatt</th><th>Datum</th><th>Orderstatus</th></tr></thead><tbody>";

                htmlOH += $"<tr><td>{orderHeadID}</td><td>{discount}</td><td>{orderDate}</td><td>{orderStatus}</td></tr>";

                htmlOH += $"</tbody><thead><tr><th>Total summa</th><th></th><th></th><th>{totalPrice.ToString("C2", CultureInfo.CurrentCulture)}</th></tr></thead></table>";

                dynamicOrder.Text = htmlOH;

                // Visa data för kunden Orderdetaljer

                string htmlOD = "";
                

                htmlOD += "<table class=\"table table-hover\"><thead><tr><th>Produkt</th><th>Pris</th><th>Antal</th></tr></thead><tbody>";

                foreach (var item in cart)
                {
                    htmlOD += $"<tr><td>{item.ArticleName}</td><td>{item.ArticlePrice.ToString("C2", CultureInfo.CurrentCulture)}</td><td>{numberOfArticles}</td></tr>";
                }


                dynamicOrderDetails.Text = htmlOD;

                Session["orderNo"] = orderHeadID;

                Response.Redirect("PayOrder.aspx");


            }
        }
    }
}