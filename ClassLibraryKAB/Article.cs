﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryKAB
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string ArticleName { get; set; }
        public decimal ArticlePrice { get; set; }
        public string ArticleCategory { get; set; }
        public string ArticleDescription { get; set; }
        public char IsActive { get; set; }
        public char IsInStock { get; set; }


        //public Article(string articleName, decimal articlePrice, string articleCategory, string articleDescription, char isActive, char isInStock)
        //{            
        //    ArticleName = articleName;
        //    ArticlePrice = articlePrice;
        //    ArticleCategory = articleCategory;
        //    ArticleDescription = articleDescription;
        //    IsActive = isActive;
        //    IsInStock = isInStock;
        //}

        public Article(int articleID, string articleName, decimal articlePrice, string articleCategory, string articleDescription, char isActive, char isInStock)
        {
            ArticleName = articleName;
            ArticlePrice = articlePrice;
            ArticleCategory = articleCategory;
            ArticleDescription = articleDescription;
            IsActive = isActive;
            IsInStock = isInStock;
        }

        public Article()
        {
            ArticleName = "";
            ArticlePrice = 0;
            ArticleCategory = "";
            ArticleDescription = "";
            IsActive = '0';
            IsInStock = '0';
        }
    }
}
