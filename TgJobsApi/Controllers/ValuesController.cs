using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TgJobsApi.Helpers;
using TgJobsApi.Models;
using System;
using System.Threading.Tasks;
using TgJobsApi.Services;

namespace TgJobsApi.Controllers
{
    [ApiController, Produces("application/json")]
    [Route("api/")]
    public class ValuesController : ControllerBase
    {
        private readonly List<Customer> customers;
        private readonly List<Product> products;
        private readonly List<SalesOrderHeader> sales;

        private readonly CustomerService customerService;

        public ValuesController(CustomerService customerService)
        {
            this.customers = CustomerHelper.generateCustomers();
            this.products = ProductHelper.generateProducts();
            this.sales = SaleHelper.getSales();

            this.customerService = customerService;
        }

        /// <summary>
        /// Endpoint para obtener un customer
        /// </summary>
        /// <returns>Un objeto Customer</returns>
        [HttpGet("getCustomer/{idCustomer}")]
        public IActionResult GetCustomer(int idCustomer)
        {
            Customer customer = this.customers.FirstOrDefault(c => c.CustomerID == idCustomer);
            return Ok(customer);
        }

        /// <summary>
        /// Endpoint para obtener las compras dado un customerId
        /// </summary>
        /// <returns>Listado de SalesOrderHeader</returns>
        [HttpGet("getSalesByCustomer/{idCustomer}/")]
        public IActionResult GetSalesByCustomer(int idCustomer)
        {
            List<SalesOrderHeader> listSales = this.sales.Where(s => s.CustomerID == idCustomer).ToList();
            return Ok(listSales);
        }

        /// <summary>
        /// Endpoint para obtener el producto más vendido
        /// </summary>
        /// <returns>Un objeto Product</returns>
        [HttpGet("getTopProduct")]
        public IActionResult GetTopProduct()
        {
           var listSales = this.sales.SelectMany(x => x.SalesOrderDetails).GroupBy(x => x.ProductID).Select(x=>new { productId = x.Key, quantity = x.Count()}).OrderByDescending(x => x.quantity);
           Product product = this.products.FirstOrDefault(p => p.ProductID == listSales.FirstOrDefault().productId);
           return Ok(product);
        }

        /// <summary>
        /// Endpoint para obtener los clientes y sus prodcutos comprados
        /// </summary>
        /// <returns>Listado de customer con array de products</returns>
        [HttpGet("getCustomerProducts")]
        public IActionResult GetCustomerProducts()
        {

            var listCustomersWithProducts = this.sales.Select(x => new { customerId = x.CustomerID, products = x.SalesOrderDetails.Select(z => z.ProductID) }).GroupBy(x => x.customerId);
            return Ok(listCustomersWithProducts);
        }

        /// <summary>
        /// Endpoint para obtener la venta más pesada (la suma de los pesos de los productos
        /// </summary>
        /// <returns>Un objeto SalesOrderHeader</returns>
        [HttpGet("getWeightestSale")]
        public IActionResult GetWeightestSale()
        {
           
            var salesWithProducts = this.sales.SelectMany(x => x.SalesOrderDetails, (x, a) => new { salesOrderID = x.SalesOrderID, productId = a.ProductID });

            var listSalesWithProductAndWeight = salesWithProducts.Join(this.products, s => s.productId, x => x.ProductID, (s, x) => new { salesOrderID = s.salesOrderID, productId = s.productId, weight = x.Weight });

            int salesOrderID = listSalesWithProductAndWeight.GroupBy(x => x.salesOrderID).OrderByDescending(x => x.Sum(z => z.weight)).FirstOrDefault().Key;

            SalesOrderHeader salesOrderHeader = this.sales.FirstOrDefault(c => c.SalesOrderID == salesOrderID);

            return Ok(salesOrderHeader);
        }


        /// <summary>
        /// Endpoint para obtener un customer usando async/await
        /// </summary>
        /// <returns>Un objeto Customer</returns>
        [HttpGet("getCustomerasync/{idCustomer}")]
        public async Task<IActionResult> GetCustomerAsync(int idCustomer)
        {
            var listCustomer  =  await this.customerService.getCustomerFromApiAsync();
            Customer customer = listCustomer.Find(x=>x.CustomerID ==idCustomer);
            return Ok(customer);
          
            
        }
    }
}
