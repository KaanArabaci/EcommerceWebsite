
using Ecommerce;

using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    class Customer : Person
    {

        Guid guid = Guid.NewGuid();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Addres { get; set; }
        public void AddBasket()
        {

        }
        public void PaymentRate()
        {

        }
        public void Pay()
        {

        }
        public void Buy()
        {

        }
        public void SendBack()
        {

        }






        
    }
}



