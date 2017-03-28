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
        bool isInStock = true;
        List<Article> articles = new List<Article>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearTextBoxesAndUncheckCheckBoxes();
            }
            
        }

        protected void ButtonAddArticle_Click(object sender, EventArgs e)
        {
            string articleName = TextBoxArticleName.Text;
            decimal articlePrice = Convert.ToDecimal(TextBoxArticlePrice.Text);
            string articleCategory = TextBoxArticleCategory.Text;
            string articleDescription = TextBoxArticleDescription.Text;
            string articleURL = TextBoxURL.Text;

            int aid = ClassLibraryKAB.SQL.CreateArticle(articleName, articlePrice, articleCategory, articleDescription, isActive, isInStock, articleURL);
            ClearTextBoxesAndUncheckCheckBoxes();
        }

        protected void CheckBoxIsActive_CheckedChanged(object sender, EventArgs e)
        {
            isActive = false;
        }

        protected void CheckBoxIsInStock_CheckedChanged(object sender, EventArgs e)
        {
            isInStock = false;
        }

        public void ClearTextBoxesAndUncheckCheckBoxes()
        {
            TextBoxArticleName.Text = "";
            TextBoxArticlePrice.Text = "";
            TextBoxArticleCategory.Text = "";
            TextBoxArticleDescription.Text = "";
            TextBoxURL.Text = "";
            CheckBoxIsActive.Checked = false;
            CheckBoxIsInStock.Checked = false;
            isActive = true;
            isInStock = true;
            LabelArticleID.Text = "";

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

                LabelArticleID.Text = myArticle.ArticleID.ToString();
                TextBoxArticleName.Text = myArticle.ArticleName;
                TextBoxArticlePrice.Text = myArticle.ArticlePrice.ToString();
                TextBoxArticleCategory.Text = myArticle.ArticleCategory;
                TextBoxArticleDescription.Text = myArticle.ArticleDescription;
                TextBoxURL.Text = myArticle.ArticleImage;

                if (myArticle.IsActive == true)
                {
                    CheckBoxIsActive.Checked = true;
                }
                else
                {
                    CheckBoxIsActive.Checked = false;
                }


                if (myArticle.IsInStock == true)
                {
                    CheckBoxIsInStock.Checked = true;
                }
                else
                {
                    CheckBoxIsInStock.Checked = false;
                }
            }
        }

        protected void ButtonUpdateArticle_Click(object sender, EventArgs e)
        {

            int articleID = Convert.ToInt32(LabelArticleID.Text);
            string articleName = TextBoxArticleName.Text;
            decimal articlePrice = Convert.ToDecimal(TextBoxArticlePrice.Text);
            string articleCategory = TextBoxArticleCategory.Text;
            string articleDescription = TextBoxArticleDescription.Text;
            string articleURL = TextBoxURL.Text;
            bool isActive;
            bool isInStock;

            if (CheckBoxIsActive.Checked)
            {
                isActive = true;
            }
            else
            {
                isActive = false;
            }


            if (CheckBoxIsInStock.Checked)
            {
                isInStock = true;
            }
            else
            {
                isInStock = false;
            }


            ClassLibraryKAB.SQL.UpdateArticle(articleID, articleName, articlePrice, articleCategory, articleDescription, isActive, isInStock, articleURL);
        }
    }
}