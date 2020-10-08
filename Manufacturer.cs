
using Ecommerce;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    class Manufacturer : Person

    {
        Guid guid = Guid.NewGuid();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public void Provide()
        {

        }

        public void AddProduct()
        {
            
          
        }

        public void Sell()
        {

        }

        public void Shipment()
        {

        }

        public void Refund()
        {

        }

        
    }
}



