using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryKAB;

namespace Projekt1_KAB
{
    public partial class MyPages : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Session["id"] != null)
            {
                Customer user = SQL.GetCustomer(Convert.ToInt32(Session["id"]));
                int customerID = Convert.ToInt32(Session["id"].ToString());

                LabelWelcome.Text = $"Välkommen {user.FirstName} {user.LastName}";
                LabelCustomerID.Text = user.CustomerID.ToString();
                LabelUserName.Text = user.UserName;
                TextBoxPassWord.Text = user.UserPassword;
                TextBoxFirstName.Text = user.FirstName;
                TextBoxLastName.Text = user.LastName;
                TextBoxAdress.Text = user.Street;
                TextBoxZip.Text = user.Zip;
                TextBoxCity.Text = user.City;
                DropDownList1.Text = user.CountryCode;
                TextBoxEmail.Text = user.Email;
                TextBoxPhoneNumber.Text = user.PhoneNumber;

                // Visa data för kunden Orderhuvud
                List<OrderHead> orderHead = SQL.ReadOrderHead(customerID);

                string htmlOH = "";

                htmlOH += "<table class=\"table table-hover\"><thead><tr><th>Din order</th><th>Rabatt</th><th>Datum</th><th>Orderstatus</th></tr></thead><tbody>";

                foreach (var item in orderHead)
                {
                    htmlOH += $"<tr><td>{item.OrderHeadID}</td><td>{item.Discount}</td><td>{item.OrderDate}</td><td>{item.OrderStatus}</td></tr>";
                }

                dynamicOrderHead.Text = htmlOH;
            }

            else
            {                
                Response.Redirect("Login.aspx");
            }
            //TODO Uppdatera användaruppgifter
            //TODO Visa orderhistorik
        }
    }
}