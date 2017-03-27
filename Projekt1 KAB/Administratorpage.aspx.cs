using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryKAB;

namespace Projekt1_KAB
{
    public partial class Administratorpage : System.Web.UI.Page
    {
        bool isActive = true;
        bool IsInStock = true;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddArticle_Click(object sender, EventArgs e)
        {
            string articleName = TextBoxArticleName.Text;
            decimal articlePrice = Convert.ToDecimal(TextBoxArticlePrice.Text);
            string articleCategory = TextBoxArticleCategory.Text;
            string articleDescription = TextBoxArticleDescription.Text;

            int aid = ClassLibraryKAB.SQL.CreateArticle(articleName, articlePrice, articleCategory, articleDescription, isActive, IsInStock);
            ClearTextBoxesAndCheckBoxes();
        }

        protected void CheckBoxIsActive_CheckedChanged(object sender, EventArgs e)
        {
            isActive = false;
        }

        protected void CheckBoxIsInStock_CheckedChanged(object sender, EventArgs e)
        {
            IsInStock = false;
        }

        public void ClearTextBoxesAndCheckBoxes()
        {
            TextBoxArticleName.Text = "";
            TextBoxArticlePrice.Text = "";
            TextBoxArticleCategory.Text = "";
            TextBoxArticleDescription.Text = "";
            CheckBoxIsActive.Checked = false;
            CheckBoxIsInStock.Checked = false;
            isActive = true;
            IsInStock = true;

        }
    }
}