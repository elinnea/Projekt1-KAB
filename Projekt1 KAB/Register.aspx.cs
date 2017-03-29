using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryKAB;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Projekt1_KAB
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (TextBoxFirstName.Text.Length > 0 && TextBoxLastName.Text.Length > 0)
            {
                int newCustomerID = SQL.AddCustomer(TextBoxUserName.Text, TextBoxPassWord.Text, TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxAdress.Text, TextBoxZip.Text, TextBoxCity.Text, DropDownList1.Text, TextBoxEmail.Text, TextBoxPhoneNumber.Text, false, true);
            }

            LabelSuccess.Visible = true;
        }
    }
}