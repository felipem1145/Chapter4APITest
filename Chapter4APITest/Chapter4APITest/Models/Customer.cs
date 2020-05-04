using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter4APITest.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}