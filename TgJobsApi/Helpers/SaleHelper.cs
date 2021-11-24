using System;
using System.Collections.Generic;
using TgJobsApi.Models;

namespace TgJobsApi.Helpers
{
    public static class SaleHelper
    {
        public static List<SalesOrderHeader> getSales()
        {
            List<SalesOrderHeader> sales = new List<SalesOrderHeader>();

            SalesOrderHeader sale1 = new SalesOrderHeader(4001, 2001, DateTime.UtcNow.AddDays(-5), DateTime.UtcNow.AddDays(-3), 3);
            sale1.SalesOrderDetails = new List<SalesOrderDetail>
            {
                new SalesOrderDetail(3001, 24.99)
            };
            SalesOrderHeader sale2 = new SalesOrderHeader(4002, 2002, DateTime.UtcNow.AddDays(-7), null, 3);
            sale2.SalesOrderDetails = new List<SalesOrderDetail>
            {
                new SalesOrderDetail(3001, 24.99),
                new SalesOrderDetail(3002, 99.99),
            };
            SalesOrderHeader sale3 = new SalesOrderHeader(4003, 2003, DateTime.UtcNow.AddDays(-15), DateTime.UtcNow.AddDays(-12), 3);
            sale3.SalesOrderDetails = new List<SalesOrderDetail>
            {
                new SalesOrderDetail(3003, 1226)
            };
            SalesOrderHeader sale4 = new SalesOrderHeader(4004, 2004, DateTime.UtcNow.AddDays(-14), DateTime.UtcNow.AddDays(-10), 3);
            sale4.SalesOrderDetails = new List<SalesOrderDetail>
            {
                new SalesOrderDetail(3004, 699),
                new SalesOrderDetail(3005, 244.49),
                new SalesOrderDetail(3004, 699)
            };
            SalesOrderHeader sale5 = new SalesOrderHeader(4005, 2005, DateTime.UtcNow.AddDays(-3), null, 3);
            sale5.SalesOrderDetails = new List<SalesOrderDetail>
            {
                new SalesOrderDetail(3001, 24.99),
                new SalesOrderDetail(3003, 1226),
                new SalesOrderDetail(3005, 244.49),
                new SalesOrderDetail(3002, 99.99),
                new SalesOrderDetail(3004, 699)
            };
            
            sales.Add(sale1);
            sales.Add(sale2);
            sales.Add(sale3);
            sales.Add(sale4);
            sales.Add(sale5);

            return sales;
        }
    }
}
