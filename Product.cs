using Ecommerce;
using System;
using System.Collections.Generic;
using System.Text;
namespace Ecommerce
{
    class Product
    {
        Guid guid = Guid.NewGuid();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
    }

}




