using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryKAB;

namespace Projekt1_KAB
{
    public partial class LoginForm_demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // When you login and click on this button your username/password combination will be evaluated
        protected void ButtonLogIN_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            //Kollar att användaren finns och att användarnamn och lösenord matchar
            //Returnerar CustomerID
            int correct = ClassLibraryKAB.SQL.VerifyUsernamePasswordCombination(username, password);


            if (correct == -1)
            {
                LabelLoginMsg.Text = "Your username or password is incorrect";
                LabelLoginMsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                LabelLoginMsg.Text = $"Your username and password is correct: {correct}";
                LabelLoginMsg.ForeColor = System.Drawing.Color.Green;

                                            
                Session["id"] = correct.ToString();
                Customer user = SQL.GetCustomer(correct);
                Session["user"] = user;
                bool admin = user.IsAdmin;

                //Dirigerar den som loggar in om den är admin eller kund
                if (admin) 
                {
                    Response.Redirect("Administratorpage.aspx");
                }
                else
                {
                    Response.Redirect("Customerpage.aspx");
                }

            }
        }
    }
}