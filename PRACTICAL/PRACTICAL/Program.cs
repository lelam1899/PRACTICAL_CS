using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAL
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            List<Product> product = new List<Product>();
            MobilePhone mobile1 = new MobilePhone(1, "phone1", 10.0, "A");
            MobilePhone mobile2 = new MobilePhone(2, "phone2", 9.0, "B");
            MobilePhone mobile3 = new MobilePhone(3, "phone3", 8.0, "C");
            Book book1 = new Book(1, "book1", 1.0 , "AA");
            Book book2 = new Book(2, "book2", 2.5, "BB");
            Book book3 = new Book(2, "book3", 3.4, "CC");
            product.Add(mobile1);
            product.Add(mobile2);
            product.Add(mobile3);
            product.Add(book1);
            product.Add(book2);
            product.Add(book3);
            foreach (Product item in product)
            {
                result += item.price;
            }
            Console.WriteLine("Total: "+result);
            Console.ReadKey();

        }
    }
}
