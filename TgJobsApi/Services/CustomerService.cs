using System.Collections.Generic;
using System.Threading.Tasks;
using TgJobsApi.Helpers;
using TgJobsApi.Models;

namespace TgJobsApi.Services
{
    public class CustomerService
    {
        public Task<List<Customer>> getCustomerFromApiAsync()
        {
            return Task.FromResult(CustomerHelper.generateCustomers());
        }
    }
}
