using NotUseIf.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotUseIf.Services
{
    public class Order
    {
        private readonly List<IProduct> _products = new();

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public decimal CalculateTotalPrice()
        {
            return _products.Sum(i => i.CalculatePrice());
        }
    }
}
