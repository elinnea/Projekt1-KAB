using ClassLibraryKAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerID = ClassLibraryKAB.SQL.AddCustomer("daga", "gr", "Johan", "Olsson", "Gata 2", "12345" ,"Sthlm", "SE", "args@b", "123456", false, true);

            int orderHeadID = ClassLibraryKAB.SQL.CreateOrderHead(customerID, 0, "170505", "In stock");

            Console.WriteLine(orderHeadID);

            List<OrderHead> orderHeads = ClassLibraryKAB.SQL.ReadOrderHeads();

            foreach (OrderHead orderHead in orderHeads)
            {
                Console.WriteLine($"{orderHead.OrderHeadID}, {orderHead.CustomerID}, {orderHead.Discount}, {orderHead.OrderDate}, {orderHead.OrderStatus}");

            }
            Console.ReadKey();
        }
    }
}
