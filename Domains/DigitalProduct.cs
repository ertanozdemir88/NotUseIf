using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotUseIf.Domains
{
    /// <summary>
    /// Dijital Ürün: Temel fiyat sabittir, kargo ücreti yoktur.
    /// </summary>
    public class DigitalProduct : Product
    {
        public DigitalProduct(decimal basePrice): base(basePrice) 
        {
            
        }
        public override decimal CalculatePrice()
        {
            return base.BasePrice;
        }
    }
}
