using ClassLibraryKAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace Projekt1_KAB.svc
{
    public partial class svc_cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["AddToCart"] != null && Request["AddToCart"].Length > 0)
            {
                int articleID = Convert.ToInt32(Request["articleID"]);
                Article article = ClassLibraryKAB.SQL.GetArticleByID(articleID);
                List<Article> cart;

                if (Session["Cart"] == null)
                {
                    cart = new List<Article>();

                }
                else
                {
                    cart = (List<Article>)Session["Cart"];

                }
                cart.Add(article);
                Session["Cart"] = cart;
                info.Text = JsonConvert.SerializeObject("Produkten är lagd i varukorgen");

            }
        }
    }
}