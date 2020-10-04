using E_Ticaret;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    class Manufacturer:IUseGuid
    {
        public Guid Guid { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }

        public void SendByCargo()
        {
            
        }

        public void Refund()
        {
           
        }
    }
}
