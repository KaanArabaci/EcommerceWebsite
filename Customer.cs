using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }


        private static void AddBasket()
        {
            string[] urun = {"kalem","kitap","defter" };
            foreach (var item in urun)
            {
                Console.WriteLine(item);
            }
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
