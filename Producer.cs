using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }

        public string SendByCargo(string city1,string city2)
        {
            return city1 + city2;
        }

        public int Refund(int Price)
        {
            return Price;
        }
    }
}
