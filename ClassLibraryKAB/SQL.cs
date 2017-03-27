using System;
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

        // CRUD for the Customer Table

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

        // ReadCustomer(int customerID)

        // UpdateCustomer()

        // DeleateCustomer()


        // CRUD for the Article Table


        List<Article> articles = new List<Article>();

        public static int CreateArticle(string articleName, decimal articlePrice, string articleCategory, string articleDescription, bool isActive, bool IsInStock, string articleImage)
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

                SqlParameter newArticleImage = new SqlParameter("@ArticleImage", myConnection);
                newArticleImage.Value = articleImage;

                SqlParameter newArticleNumber = new SqlParameter("@ArticleID", SqlDbType.Int);
                newArticleNumber.Direction = ParameterDirection.Output;

                myCommand.Parameters.Add(newArticleName);
                myCommand.Parameters.Add(newArticlePrice);
                myCommand.Parameters.Add(newArticleCategory);
                myCommand.Parameters.Add(newArticleDescription);
                myCommand.Parameters.Add(newIsActive);
                myCommand.Parameters.Add(newIsInStock);
                myCommand.Parameters.Add(newArticleNumber);
                myCommand.Parameters.Add(newArticleImage);


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

        public static List<Article> ReadArticles()
        {
            List<Article> articles = new List<Article>();
            SqlConnection myConnection = new SqlConnection(source);

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("select * from Article order by ArticleID asc", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    articles.Add(new Article(
                    Convert.ToInt32(myReader["ArticleID"].ToString()),
                    myReader["ArticleName"].ToString(),
                    Convert.ToDecimal(myReader["ArticlePrice"].ToString()),
                    myReader["ArticleCategory"].ToString(),
                    myReader["ArticleDescription"].ToString(),
                    Convert.ToBoolean(myReader["IsActive"].ToString()),
                    Convert.ToBoolean(myReader["IsInStock"].ToString()),
                    myReader["ArticleImage"].ToString()
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

        public Article GetArticleByID(int inputID)
        {
            SqlConnection myConnection = new SqlConnection(source);
            Article myArticle = new Article();

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("SearchArticleByID", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter articleID = new SqlParameter("@FindArticleByID", SqlDbType.Int);
                articleID.Value = inputID;

                myCommand.Parameters.Add(articleID);

                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    myArticle = new Article(
                    Convert.ToInt32(myReader["ArticleID"].ToString()),
                    myReader["ArticleName"].ToString(),
                    Convert.ToDecimal(myReader["ArticlePrice"].ToString()),
                    myReader["ArticleCategory"].ToString(),
                    myReader["ArticleDescription"].ToString(),
                    Convert.ToBoolean(myReader["IsActive"].ToString()),
                    Convert.ToBoolean(myReader["IsInStock"].ToString()),
                    myReader["ArticleImage"].ToString()
                    );
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { myConnection.Close(); }

            return myArticle;
        }

        public List<Article> GetArticleByName(string inputName)
        {
            SqlConnection myConnection = new SqlConnection(source);
            List<Article> articles = new List<Article>();

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("SearchArticleByName", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter articleName = new SqlParameter("@FindArticleByName", SqlDbType.NVarChar);
                articleName.Value = "%" + inputName + "%";

                myCommand.Parameters.Add(articleName);

                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    articles.Add(new Article(
                    Convert.ToInt32(myReader["ArticleID"].ToString()),
                    myReader["ArticleName"].ToString(),
                    Convert.ToDecimal(myReader["ArticlePrice"].ToString()),
                    myReader["ArticleCategory"].ToString(),
                    myReader["ArticleDescription"].ToString(),
                    Convert.ToBoolean(myReader["IsActive"].ToString()),
                    Convert.ToBoolean(myReader["IsInStock"].ToString()),
                    myReader["ArticleImage"].ToString()
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

        public static void UpdateArticle(int ArticleID, string articleName, double articlePrice, string articleCategory, string articleDescription, bool isActive, bool IsInStock, string articleImage)
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

                SqlParameter newArticleImage = new SqlParameter("@ArticleImage", myConnection);
                newArticleImage.Value = articleImage;

                myCommand.Parameters.Add(newArticleNumber);
                myCommand.Parameters.Add(newArticleName);
                myCommand.Parameters.Add(newArticlePrice);
                myCommand.Parameters.Add(newArticleCategory);
                myCommand.Parameters.Add(newArticleDescription);
                myCommand.Parameters.Add(newIsActive);
                myCommand.Parameters.Add(newIsInStock);
                myCommand.Parameters.Add(newArticleImage);

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


        // CRUD for the OrderHead Table


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

        public static List<OrderHead> ReadOrderHead(int CustomerID)
        {
            List<OrderHead> orderHeads = new List<OrderHead>();

            SqlConnection myConnection = new SqlConnection(source);

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("SELECT * FROM OrderHead WHERE CustomerID = @cid", myConnection);
                myCommand.Parameters.Add("@cid", SqlDbType.Int).Value = CustomerID;

                SqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                        orderHeads.Add(new OrderHead(
                                                    (Convert.ToInt32(reader["OrderHeadID"].ToString())),
                                                    (Convert.ToInt32(reader["CustomerID"].ToString())),
                                                    (Convert.ToDecimal(reader["Discount"].ToString())),
                                                    reader["OrderDate"].ToString(),
                                                    reader["OrderStatus"].ToString()));
                }
            }

            finally
            {
                myConnection.Close();
            }
            return orderHeads;
        }

        //UpdateOrderHead stored procedure not ready!
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

        public static void DeleateOrderHead(int OrderHeadID)
        {
            SqlConnection myConnection = new SqlConnection(source);

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand($"delete from OrderHead where OrderHeadID = {OrderHeadID}", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { myConnection.Close(); }
        }


        // CRUD for the OrderDetail Table


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

        public static List<OrderDetail> ReadOrderDetail(int orderHeadID)
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

        // ReadOrderDetail()

        public void UpdateOrderDetail()
        {
            //return TODO;
        }

        // DeleteOrderDetail()


        //LOGIN. Function that returns a CustomerID if the username/password combination exist and -1 if not

        public static int VerifyUsernamePasswordCombination(string username, string password)
        {
            SqlConnection myConnection = new SqlConnection(source);
            try

            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("SELECT CustomerID FROM Customer WHERE UserName = @name AND UserPassword = @password", myConnection);
                myCommand.Parameters.Add("@name", SqlDbType.VarChar);
                myCommand.Parameters["@name"].Value = username;
                myCommand.Parameters.Add("@password", SqlDbType.VarChar);
                myCommand.Parameters["@password"].Value = password;

                var x = myCommand.ExecuteReader();
                if (x.Read())
                {
                    return Convert.ToInt32(x[0]);
                }
                else
                {
                    return -1;
                }
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}


