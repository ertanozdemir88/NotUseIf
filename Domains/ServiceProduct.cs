using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotUseIf.Domains
{
    /// <summary>
    /// Hizmet: Temel fiyat üzerine hizmet süresi çarpanı eklenir.
    /// </summary>
    public class ServiceProduct : Product
    {
        private readonly decimal _timeMultiplier;

        public ServiceProduct(decimal basePrice, decimal timeMultiplier): base(basePrice) 
        {
            _timeMultiplier = timeMultiplier;
        }

        public override decimal CalculatePrice()
        {
            return base.BasePrice * _timeMultiplier;
        }
    }
}
