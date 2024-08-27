using NotUseIf.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotUseIf.Domains
{
    public abstract class Product : IProduct
    {
        protected decimal BasePrice;

        protected Product(decimal basePrice)
        {
            BasePrice = basePrice;
        }
        public abstract decimal CalculatePrice();
    }
}
