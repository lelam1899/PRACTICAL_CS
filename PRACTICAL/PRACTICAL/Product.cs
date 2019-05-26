using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAL
{
    public abstract class Product
    {
        public int id;
        public string name;
        public double price;
        public string producer;

        public Product(int id, string name, double price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }
        public abstract double computeTax();
    }
}
