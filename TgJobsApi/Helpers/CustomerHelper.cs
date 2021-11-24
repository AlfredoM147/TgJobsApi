using System.Collections.Generic;
using TgJobsApi.Models;

namespace TgJobsApi.Helpers
{
    public static class CustomerHelper
    {
        public static List<Customer> generateCustomers()
        {
            List<Customer> customers = new List<Customer>();

            Customer customer1 = new Customer(2001, "Kenny Krause", "Kennykrause@gustr.com");
            Customer customer2 = new Customer(2002, "Bill Atkins", "billatkins@gustr.com");
            Customer customer3 = new Customer(2003, "Dwight January", "dwightjanuary@gustr.com");
            Customer customer4 = new Customer(2004, "Theresa Patrick", "theresapatrick@gustr.com");
            Customer customer5 = new Customer(2005, "John Doe", "johndoe@gustr.com");

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            customers.Add(customer5);

            return customers;
        }
    }
}
