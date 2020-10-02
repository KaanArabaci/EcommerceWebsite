using Ecommerce;
using System;

namespace Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.City = "izmir";

            Producer producer = new Producer();
            producer.City = "denizli";
            
            var direction = producer.SendByCargo(producer.City , customer.City);
            Console.WriteLine(direction);

            
            
            
            Console.ReadLine();

        }

        
    }
}
