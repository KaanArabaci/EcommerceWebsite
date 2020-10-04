using E_Ticaret;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    class Product:IUseGuid
    {
        public Guid Guid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
    }
}
