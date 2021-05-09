using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the following connection string.
            Northwnd db = new Northwnd(@"c:\linqtest5\northwnd.mdf");
            // Create the new Customer object.
            Customer newCust = new Customer();
            newCust.CompanyName = "AdventureWorks Cafe";
            newCust.CustomerID = "ADVCA";

            // Add the customer to the Customers table.
            db.Customers.InsertOnSubmit(newCust);

            Console.WriteLine("\nCustomers matching CA before insert");

            foreach (var c in db.Customers.Where(cust => cust.CustomerID.Contains("CA")))
            {
                Console.WriteLine("{0}, {1}, {2}",
                    c.CustomerID, c.CompanyName, c.Orders.Count);
            }

            // Query for specific customer.
            // First() returns one object rather than a collection.
            var existingCust =
                (from c in db.Customers
                 where c.CustomerID == "ALFKI"
                 select c)
                .First();

            // Change the contact name of the customer.
            existingCust.ContactName = "New Contact";

            // Access the first element in the Orders collection.
            Order ord0 = existingCust.Orders[0];

            // Access the first element in the OrderDetails collection.
            OrderDetail detail0 = ord0.OrderDetails[0];

            // Display the order to be deleted.
            Console.WriteLine
                ("The Order Detail to be deleted is: OrderID = {0}, ProductID = {1}",
                detail0.OrderID, detail0.ProductID);

            // Mark the Order Detail row for deletion from the database.
            db.OrderDetails.DeleteOnSubmit(detail0);
            db.SubmitChanges();
            Console.WriteLine("\nCustomers matching CA after update");
            foreach (var c in db.Customers.Where(cust =>
                cust.CustomerID.Contains("CA")))
            {
                Console.WriteLine("{0}, {1}, {2}",
                    c.CustomerID, c.CompanyName, c.Orders.Count);
            }

            // Keep the console window open after activity stops.
            Console.ReadLine();
        }
    }
}
