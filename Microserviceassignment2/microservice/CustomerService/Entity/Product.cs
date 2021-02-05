﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public Guid ExternalID { get;set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }

        public int quatity { get; set; }
        public decimal price { get; set; }

    }
}
