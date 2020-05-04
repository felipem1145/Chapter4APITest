using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Chapter4APITest.Models;

namespace Chapter4APITest.Controllers
{
    public class CustomerController : ApiController
    {
     

        public IEnumerable<Customer> GetCustomers(int accountId)
        {
            return DataRepository.Customers.Where(cust =>
            cust.AccountId == accountId);
        }
        public IEnumerable<Customer> SearchCustomers(string lastName)
        {
            return DataRepository.Customers.Where(cust =>
            cust.LastName.ToLower().Contains(lastName.ToLower()));
        }
    }
}
