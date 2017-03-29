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

                if (!IsPostBack)
                {
                    LabelWelcome.Text += $"Välkommen {user.FirstName} {user.LastName}";
                    LiteralWelcome.Text += $"Nedan kan du ändra dina uppgifter:";
                    
                    LabelCustomerID.Text = user.CustomerID.ToString();
                    LabelUserName.Text = user.UserName;
                    TextBoxPassWord.Text = user.UserPassword;
                    TextBoxFirstName.Text = user.FirstName;
                    TextBoxLastName.Text = user.LastName;
                    TextBoxAdress.Text = user.Street;
                    TextBoxZip.Text = user.Zip;
                    TextBoxCity.Text = user.City;
                    DropDownListCountryCode.Text = user.CountryCode;
                    TextBoxEmail.Text = user.Email;
                    TextBoxPhoneNumber.Text = user.PhoneNumber;
                }

                LiteralOrderHeadInfo.Text = "Här ser du dina tidigare ordrar:";
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


        protected void ButtonUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                int customerID = Convert.ToInt32(Session["id"]);
                string userName = LabelUserName.Text;
                string passWord = TextBoxPassWord.Text;
                string firstName = TextBoxFirstName.Text;
                string lastName = TextBoxLastName.Text;
                string adress = TextBoxAdress.Text;
                string zip = TextBoxZip.Text;
                string city = TextBoxCity.Text;
                string countryCode = DropDownListCountryCode.Text;
                string email = TextBoxEmail.Text;
                string phonenumber = TextBoxPhoneNumber.Text;

                ClassLibraryKAB.SQL.UpdateCustomer(customerID, userName, passWord, firstName, lastName, adress, zip, city, countryCode, email, phonenumber);
            }
        }
    }
}