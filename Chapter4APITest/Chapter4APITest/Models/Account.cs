using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter4APITest.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountAlias { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}