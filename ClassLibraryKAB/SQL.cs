﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryKAB
{
    public class SQL
    {
        static string source = "Data Source=.;Initial Catalog=KontorsprylarAB;Integrated Security=True";

        public static int CreateOrderHead(int customerID, decimal discount, string orderDate, string orderStatus)
        {
            int new_ID = 0;

            SqlConnection myConnection = new SqlConnection(source);

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("CreateOrderHead", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;                        // För att använda stored procedure

                // Skapa parametrar

                SqlParameter myCustomerID = new SqlParameter("@CustomerID", SqlDbType.VarChar);
                myCustomerID.Value = customerID;

                SqlParameter myDiscount = new SqlParameter("@Discount", SqlDbType.VarChar);
                myDiscount.Value = discount;

                SqlParameter myOrderDate = new SqlParameter("@OrderDate", SqlDbType.VarChar);
                myOrderDate.Value = orderDate;

                SqlParameter myOrderStatus = new SqlParameter("@OrderStatus", SqlDbType.VarChar);
                myOrderStatus.Value = orderStatus;

                SqlParameter newOrderHeadID = new SqlParameter("@OrderHeadID", SqlDbType.Int);
                newOrderHeadID.Direction = ParameterDirection.Output;

                myCommand.Parameters.Add(myCustomerID);
                myCommand.Parameters.Add(myDiscount);
                myCommand.Parameters.Add(myOrderDate);
                myCommand.Parameters.Add(myOrderStatus);
                myCommand.Parameters.Add(newOrderHeadID);

                myCommand.ExecuteNonQuery();
                new_ID = (int)newOrderHeadID.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }

            return new_ID;

        }

        public static List<OrderHead> ReadOrderHeads()
        {
            List<OrderHead> orderHeads = new List<OrderHead>();

            SqlConnection myConnection = new SqlConnection(source);


            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = "select * from OrderHead";

                SqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    orderHeads.Add(new OrderHead(
                                                (Convert.ToInt32(myReader["OrderHeadID"].ToString())),
                                                (Convert.ToInt32(myReader["CustomerID"].ToString())),
                                                (Convert.ToDecimal(myReader["Discount"].ToString())),
                                                myReader["OrderDate"].ToString(),
                                                myReader["OrderStatus"].ToString()));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            return orderHeads;
        }

        public static void UpdateOrderHead(int orderHeadID, int customerID, decimal discount, string orderDate, string orderStatus)
        {

            SqlConnection myConnection = new SqlConnection(source);

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("UpdateOrderHead", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;                        // För att använda stored procedure

                // Skapa parametrar

                SqlParameter myCustomerID = new SqlParameter("@CustomerID", SqlDbType.VarChar);
                myCustomerID.Value = customerID;

                SqlParameter myDiscount = new SqlParameter("@Discount", SqlDbType.VarChar);
                myDiscount.Value = discount;

                SqlParameter myOrderDate = new SqlParameter("@OrderDate", SqlDbType.VarChar);
                myOrderDate.Value = orderDate;

                SqlParameter myOrderStatus = new SqlParameter("@OrderStatus", SqlDbType.VarChar);
                myOrderStatus.Value = orderStatus;

                SqlParameter myOrderHeadID = new SqlParameter("@OrderHeadID", SqlDbType.Int);
                myOrderHeadID.Value = orderHeadID;

                myCommand.Parameters.Add(myCustomerID);
                myCommand.Parameters.Add(myDiscount);
                myCommand.Parameters.Add(myOrderDate);
                myCommand.Parameters.Add(myOrderStatus);
                myCommand.Parameters.Add(myOrderHeadID);

                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }

        }

        public static void DeleateOrderHead()
        {

        }

        List<Article> articles = new List<Article>();

        public int CreateArticle(string articleName, decimal articlePrice, string articleCategory, string articleDescription, char isActive, char IsInStock)
        {
            SqlConnection myConnection = new SqlConnection(source);
            int newID = 0;

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("CreateArticle", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter newArticleName = new SqlParameter("@ArticleName", SqlDbType.VarChar);
                newArticleName.Value = articleName;

                SqlParameter newArticlePrice = new SqlParameter("@ArticlePrice", myConnection);
                newArticlePrice.Value = articlePrice;

                SqlParameter newArticleCategory = new SqlParameter("@ArticleCategory", myConnection);
                newArticleCategory.Value = articleCategory;

                SqlParameter newArticleDescription = new SqlParameter("@ArticleDescription", myConnection);
                newArticleDescription.Value = articleDescription;

                SqlParameter newIsActive = new SqlParameter("@IsActive", myConnection);
                newIsActive.Value = isActive;

                SqlParameter newIsInStock = new SqlParameter("@IsInStock", myConnection);
                newIsInStock.Value = IsInStock;

                SqlParameter newArticleNumber = new SqlParameter("@ArticleID", SqlDbType.Int);
                newArticleNumber.Direction = ParameterDirection.Output;

                myCommand.Parameters.Add(newArticleName);
                myCommand.Parameters.Add(newArticlePrice);
                myCommand.Parameters.Add(newArticleCategory);
                myCommand.Parameters.Add(newArticleDescription);
                myCommand.Parameters.Add(newIsActive);
                myCommand.Parameters.Add(newIsInStock);
                myCommand.Parameters.Add(newArticleNumber);


                myCommand.ExecuteNonQuery();

                newID = (int)newArticleNumber.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { myConnection.Close(); }

            return newID;
        }

        public List<Article> ReadArticles()
        {
            SqlConnection myConnection = new SqlConnection(source);

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("select * from Article order by ArticleID asc", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    articles.Add(new Article(
                    (int)myReader["ArticleID"],
                    (string)myReader["ArticleName"],
                    (decimal)myReader["ArticlePrice"],
                    (string)myReader["ArticleCategory"],
                    (string)myReader["ArticleDescription"],
                    (char)myReader["IsActive"],
                    (char)myReader["IsInStock"]
                    ));
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { myConnection.Close(); }

            return articles;
        }

        //public Article GetArticle(int articleID) //NOT READY!!!
        //{
        //    SqlConnection myConnection = new SqlConnection(source);
        //    Article myArticle = new Article();

        //    try
        //    {
        //        myConnection.Open();

        //        SqlCommand myCommand = new SqlCommand("select * from Article order by ArticleID asc", myConnection);
        //        SqlDataReader myReader = myCommand.ExecuteReader();


        //        while (myReader.Read())
        //        {
        //                myArticle = new Article(
        //                Convert.ToInt32(myReader["ArticleID"].ToString()),
        //                myReader["ArticleName"].ToString(),
        //                Convert.ToDecimal(myReader["ArticlePrice"].ToString()),
        //                myReader["ArticleCategory"].ToString(),
        //                myReader["ArticleDescription"].ToString(),
        //                myReader["IsActive"],
        //                myReader["IsInStock"]);
        //        }


        //    }
        //    //catch (Exception ex)
        //    //{
        //    //    Console.WriteLine(ex.Message);
        //    //}
        //    finally { myConnection.Close(); }

        //    return myArticle;
        //}

        public void UpdateArticle(int ArticleID, string articleName, double articlePrice, string articleCategory, string articleDescription, bool isActive, bool IsInStock)
        {

            SqlConnection myConnection = new SqlConnection(source);

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("UpdateArticle", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter newArticleNumber = new SqlParameter("@ArticleID", SqlDbType.Int);
                newArticleNumber.Value = ArticleID;

                SqlParameter newArticleName = new SqlParameter("@ArticleName", SqlDbType.VarChar);
                newArticleName.Value = articleName;

                SqlParameter newArticlePrice = new SqlParameter("@ArticlePrice", myConnection);
                newArticlePrice.Value = articlePrice;

                SqlParameter newArticleCategory = new SqlParameter("@ArticleCategory", myConnection);
                newArticleCategory.Value = articleCategory;

                SqlParameter newArticleDescription = new SqlParameter("@ArticleDescription", myConnection);
                newArticleDescription.Value = articleDescription;

                SqlParameter newIsActive = new SqlParameter("@IsActive", myConnection);
                newIsActive.Value = isActive;

                SqlParameter newIsInStock = new SqlParameter("@IsInStock", myConnection);
                newIsInStock.Value = IsInStock;

                myCommand.Parameters.Add(newArticleNumber);
                myCommand.Parameters.Add(newArticleName);
                myCommand.Parameters.Add(newArticlePrice);
                myCommand.Parameters.Add(newArticleCategory);
                myCommand.Parameters.Add(newArticleDescription);
                myCommand.Parameters.Add(newIsActive);
                myCommand.Parameters.Add(newIsInStock);

                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { myConnection.Close(); }
        }

        public void DeleteArticle(int ArticleID)
        {
            SqlConnection myConnection = new SqlConnection(source);

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand($"delete from Article where ArticleID = {ArticleID} and IsActive = 0", myConnection); //Säkerhetsheck! Ta inte bort en aktiv artikel
                SqlDataReader myReader = myCommand.ExecuteReader();

                //TODO felmeddelande som säger att det inte går att ta bort en aktiv artikel
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { myConnection.Close(); }
        }

        public static List<OrderDetail> ReadOrderDetails(int orderHeadID)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            SqlConnection myConnection = new SqlConnection(source);

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand($"select * from OrderDetails where OrderHeadID = {orderHeadID} order by OrderDetailsID asc", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    int OrderDetailsID = Convert.ToInt32(myReader["OrderDetailsID"].ToString());
                    int OrderHeadID = Convert.ToInt32(myReader["OrderHeadID"].ToString());
                    int ArticleID = Convert.ToInt32(myReader["ArticleID"].ToString());
                    decimal Price = Convert.ToDecimal(myReader["Price"].ToString());
                    int NumberOfArticles = Convert.ToInt32(myReader["NumberOfArticles"].ToString());

                    orderDetails.Add(new OrderDetail(OrderDetailsID, OrderHeadID, ArticleID, Price, NumberOfArticles));

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            return orderDetails;
        }

        public static void CreateOrderDetail(int orderHeadID)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = source;

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand($"select * from OrderDetails where OrderHeadID = {orderHeadID} order by OrderDetailsID asc", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    int OrderHeadID = Convert.ToInt32(myReader["OrderHeadID"].ToString());
                    int ArticleID = Convert.ToInt32(myReader["ArticleID"].ToString());
                    decimal Price = Convert.ToDecimal(myReader["Price"].ToString());
                    int NumberOfArticles = Convert.ToInt32(myReader["NumberOfArticles"].ToString());

                    orderDetails.Add(new OrderDetail(OrderHeadID, ArticleID, Price, NumberOfArticles));

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public void Update()
        {
            //return TODO;
        }

        public static int AddCustomer(string userName, string userPassword, string firstName, string lastName, string street, string zip, string city, string countryCode, string email, string phoneNumber, bool isAdmin, bool isActive)
        {
            int nID = 0;
            SqlConnection myConnection = new SqlConnection(source);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("AddCustomer", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter newUserName = new SqlParameter("@userName", SqlDbType.VarChar);
                newUserName.Value = userName;
                SqlParameter newUserPassword = new SqlParameter("@userPassword", SqlDbType.VarChar);
                newUserPassword.Value = userPassword;
                SqlParameter newFirstName = new SqlParameter("@firstName", SqlDbType.VarChar);
                newFirstName.Value = firstName;
                SqlParameter newLastName = new SqlParameter("@lastName", SqlDbType.VarChar);
                newLastName.Value = lastName;
                SqlParameter newStreet = new SqlParameter("@street", SqlDbType.VarChar);
                newStreet.Value = street;
                SqlParameter newZip = new SqlParameter("@zip", SqlDbType.VarChar);
                newZip.Value = zip;
                SqlParameter newCity = new SqlParameter("@city", SqlDbType.VarChar);
                newCity.Value = city;
                SqlParameter newCountryCode = new SqlParameter("@countryCode", SqlDbType.VarChar);
                newCountryCode.Value = countryCode;
                SqlParameter newEmail = new SqlParameter("@email", SqlDbType.VarChar);
                newEmail.Value = email;
                SqlParameter newPhoneNumber = new SqlParameter("@phoneNumber", SqlDbType.VarChar);
                newPhoneNumber.Value = phoneNumber;
                SqlParameter newIsAdmin = new SqlParameter("@isAdmin", SqlDbType.VarChar);
                newIsAdmin.Value = isAdmin;
                SqlParameter newIsActive = new SqlParameter("@isActive", SqlDbType.VarChar);
                newIsActive.Value = isActive;

                SqlParameter customerID = new SqlParameter("@customer_id", SqlDbType.Int);
                customerID.Direction = ParameterDirection.Output;

                myCommand.Parameters.Add(newUserName);
                myCommand.Parameters.Add(newUserPassword);
                myCommand.Parameters.Add(newFirstName);
                myCommand.Parameters.Add(newLastName);
                myCommand.Parameters.Add(newStreet);
                myCommand.Parameters.Add(newZip);
                myCommand.Parameters.Add(newCity);
                myCommand.Parameters.Add(newCountryCode);
                myCommand.Parameters.Add(newEmail);
                myCommand.Parameters.Add(newPhoneNumber);
                myCommand.Parameters.Add(newIsAdmin);
                myCommand.Parameters.Add(newIsActive);
                myCommand.Parameters.Add(customerID);

                myCommand.ExecuteNonQuery();
                nID = (int)customerID.Value;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                myConnection.Close();
            }
            return nID;
        }


        public static List<Customer> ReadAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = source;
            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("select * from Customer", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    customers.Add(new Customer(Convert.ToInt32(myReader["CustomerID"].ToString()), myReader["UserName"].ToString(), myReader["UserPassword"].ToString(),
                    myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["Street"].ToString(), myReader["Zip"].ToString(), myReader["City"].ToString(),
                    myReader["CountryCode"].ToString(), myReader["Email"].ToString(), myReader["PhoneNumber"].ToString(), Convert.ToBoolean(myReader["IsAdmin"]), Convert.ToBoolean(myReader["IsActive"])));
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            finally
            {
                myConnection.Close();
            }
            return customers;
        }

    }
}

