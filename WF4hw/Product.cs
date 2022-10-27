using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF4hw
{
    public class Product
    {
        public string Name { get; set; }
        public string MadeIn { get; set; }
        public double Price { get; set; }

        public Product()
        { }
        public Product(string name, string madeIn, double price)
        {
            Name = name;
            MadeIn = madeIn;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Made In: {MadeIn}, Price: {Price}";
        }
    }
}
