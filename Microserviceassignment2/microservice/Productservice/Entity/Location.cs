using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productservice.Entity
{
    public class Location
    {
        public int LocationId { get; set; }
        public string street { get; set; }
        public string City { get; set; }
        public string  Country{ get; set; }
        public int  Zip { get; set; }
       }
}
