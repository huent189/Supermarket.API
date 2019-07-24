using System;
using System.Collections;
using System.Collections.Generic;

namespace Supermarket.API.Domain.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
