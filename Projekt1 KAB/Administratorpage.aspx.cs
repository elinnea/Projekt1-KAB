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
        List<Article> articles = new List<Article>();

        protected void Page_Load(object sender, EventArgs e)
        {
            ClearTextBoxesAndUncheckCheckBoxes();
        }

        protected void ButtonAddArticle_Click(object sender, EventArgs e)
        {
            string articleName = TextBoxArticleName.Text;
            decimal articlePrice = Convert.ToDecimal(TextBoxArticlePrice.Text);
            string articleCategory = TextBoxArticleCategory.Text;
            string articleDescription = TextBoxArticleDescription.Text;

            int aid = ClassLibraryKAB.SQL.CreateArticle(articleName, articlePrice, articleCategory, articleDescription, isActive, IsInStock);
            ClearTextBoxesAndUncheckCheckBoxes();
        }

        protected void CheckBoxIsActive_CheckedChanged(object sender, EventArgs e)
        {
            isActive = false;
        }

        protected void CheckBoxIsInStock_CheckedChanged(object sender, EventArgs e)
        {
            IsInStock = false;
        }

        public void ClearTextBoxesAndUncheckCheckBoxes()
        {
            TextBoxArticleName.Text = "Ange artikelnamn";
            TextBoxArticlePrice.Text = "Ange artikelpris";
            TextBoxArticleCategory.Text = "Ange artikelkategori";
            TextBoxArticleDescription.Text = "Ange beskrivning";
            CheckBoxIsActive.Checked = false;
            CheckBoxIsInStock.Checked = false;
            isActive = true;
            IsInStock = true;

        }

        protected void ButtonReadArticles_Click(object sender, EventArgs e)
        {
            articles = ClassLibraryKAB.SQL.ReadArticles();

            foreach (Article article in articles)
            {
                ListBoxArticles.Items.Add($"{article.ArticleName}");
            }
        }

        protected void ListBoxArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            articles = ClassLibraryKAB.SQL.ReadArticles();
            int index = ListBoxArticles.SelectedIndex;

            if (index >= 0)
            {
                Article myArticle = articles.ElementAt(index);

                TextBoxArticleName.Text = myArticle.ArticleName;
            }
        }
    }
}