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
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            int correct = ClassLibraryKAB.SQL.VerifyUsernamePasswordCombination(username, password);


            if (correct == -1)
            {
                Label1.Text = "Your username or password is incorrect";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                Label1.Text = $"Your username and password is correct: {correct}";
                Label1.ForeColor = System.Drawing.Color.Green;

                // The customerID is saved for the Customer that logs in succesfully
                // You are transfered to the user site
                // We should ask IsAdmin here and redirect to admin site!!
                            
                Session["id"] = correct.ToString();
                Customer user = SQL.GetCustomer(correct);
                Session["user"] = user;
                bool admin = user.IsAdmin;

                if (admin)
                {
                    Response.Redirect("Administratorpage.aspx");
                }
                else
                {
                    Response.Redirect("Customerpage.aspx");
                }
                
                Session.RemoveAll();
            }
        }
    }
}