using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public Guid ExternalID { get;,set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int Mobile { get; set; }
        public string Address { get; set; }
        public Product Product { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public decimal price { get; set; }
    }
}
