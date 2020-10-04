using E_Ticaret;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    class Customer : IUseGuid
    {

        public Guid Guid { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }


        public void AddBasket()
        {
           
        }

        public  void Buy()
        {

        }

        public void  SendBack()
        {

        }

        public void PaymentRate()
        {

        }


    }
}
