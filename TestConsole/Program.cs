using ClassLibraryKAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole // Used for testing the functionalities of the ClassLibraryKAB
{
    class Program
    {
        static void Main(string[] args)
        {
            // CUSTOMER

            //int customerID = ClassLibraryKAB.SQL.AddCustomer("daga", "gr", "Johan", "Olsson", "Gata 2", "12345", "Sthlm", "SE", "args@b", "123456", false, true);

            //Console.WriteLine($"A customer with the ID { customerID} was added.");

            //List<Customer> customers = ClassLibraryKAB.SQL.ReadAllCustomers();

            //Console.WriteLine("Customers:");
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer.ToString());
            //}

            // ORDERHEAD

            //int orderHeadID = ClassLibraryKAB.SQL.CreateOrderHead(3005, 0, "170505", "In stock");

            //Console.WriteLine($"An orderhead with the ID {orderHeadID} was created");

            //    List<OrderHead> orderHeads = ClassLibraryKAB.SQL.ReadOrderHeads();

            //    Console.WriteLine("OrderHeads:");
            //    foreach (OrderHead orderHead in orderHeads)
            //    {
            //        Console.WriteLine($"{orderHead.OrderHeadID}, {orderHead.CustomerID}, {orderHead.Discount}, {orderHead.OrderDate}, {orderHead.OrderStatus}");

            //    }

            //    List<OrderHead> orderHeads2 = ClassLibraryKAB.SQL.ReadOrderHead(1003);

            //    foreach (OrderHead orderHead in orderHeads2)
            //    {
            //        Console.WriteLine($"{orderHead.OrderHeadID}, {orderHead.CustomerID}, {orderHead.Discount}, {orderHead.OrderDate}, {orderHead.OrderStatus}");

            //    }

            //    ClassLibraryKAB.SQL.UpdateOrderHead(1002, 3006, 0, "170505", "Not in stock");

            //    ClassLibraryKAB.SQL.DeleateOrderHead(1008);

            //    Console.ReadKey();

            //List<Article> articles = ClassLibraryKAB.SQL.ReadArticles();

            //foreach (var item in articles)
            //{
            //    Console.WriteLine(item.ArticleID);
            //    Console.ReadLine();
            //}

            //string orderDate = DateTime.Today.ToString();

            //Console.WriteLine(orderDate);

            //Console.ReadKey();
        }
    }
}
