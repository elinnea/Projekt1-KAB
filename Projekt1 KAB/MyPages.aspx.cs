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
            Customer user = SQL.GetCustomer(Convert.ToInt32(Session["id"]));

            if (Session["id"] != null)
            {                
                LabelCustomerID.Text = user.CustomerID.ToString();
                LabelUserName.Text = user.UserName;
                TextBoxPassWord.Text = user.UserPassword;
                TextBoxFirstName.Text = user.FirstName;
                TextBoxLastName.Text = user.LastName;
                TextBoxAdress.Text = user.Street;
                TextBoxZip.Text = user.Zip;
                TextBoxCity.Text = user.City;
                TextBoxCountryCode.Text = user.CountryCode;
                TextBoxEmail.Text = user.Email;
                TextBoxPhoneNumber.Text = user.PhoneNumber;
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