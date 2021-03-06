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
        public bool IsActive { get; set; }
        public bool IsInStock { get; set; }
        public string ArticleImage { get; set; }


        public Article(string articleName, decimal articlePrice, string articleCategory, string articleDescription, bool isActive, bool isInStock, string articleImage)
        {
            
            ArticleName = articleName;
            ArticlePrice = articlePrice;
            ArticleCategory = articleCategory;
            ArticleDescription = articleDescription;
            IsActive = isActive;
            IsInStock = isInStock;
            ArticleImage = articleImage;
        }

        public Article(int articleID, string articleName, decimal articlePrice, string articleCategory, string articleDescription, bool isActive, bool isInStock, string articleImage)
        {
            
            ArticleID = articleID;
            ArticleName = articleName;
            ArticlePrice = articlePrice;
            ArticleCategory = articleCategory;
            ArticleDescription = articleDescription;
            IsActive = isActive;
            IsInStock = isInStock;
            ArticleImage = articleImage;
        }

        public Article()
        {
            
            ArticleName = "";
            ArticlePrice = 0;
            ArticleCategory = "";
            ArticleDescription = "";
            IsActive = false;
            IsInStock = false;
            ArticleImage = "";
        }
    }
}

