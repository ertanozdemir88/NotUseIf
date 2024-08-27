using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotUseIf.Domains
{
    /// <summary>
    /// Fiziksel Ürün: Temel fiyat üzerine kargo ücreti eklenir.
    /// </summary>
    public class PhysicalProduct : Product
    {
        private readonly decimal _shippingCost;

        public PhysicalProduct(decimal basePrice, decimal shippingCost): base(basePrice) 
        {
                _shippingCost = shippingCost;
        }
        public override decimal CalculatePrice()
        {
            return base.BasePrice + _shippingCost;
        }
    }
}
