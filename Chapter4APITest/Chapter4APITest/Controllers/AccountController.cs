using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Chapter4APITest.Models;

namespace Chapter4APITest.Controllers
{
    public class AccountController : ApiController
    {
      

        public IEnumerable<Account> GetAccounts()
        {
            return DataRepository.Accounts;
        }
        public Account GetAccount(int accountId)
        {
            Account result = DataRepository.Accounts.SingleOrDefault(acc =>
            acc.AccountId == accountId);
            if (result == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return result;
        }
    }
}
