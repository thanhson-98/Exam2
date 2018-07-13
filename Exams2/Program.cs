using System;
using System.Collections.Generic;

namespace Exams2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            var productname = "";

            for(int i = 0; i < 5; i++)
            {
                if(i < 3) {
                    // products[i]
                    products[i] = new Book();
                    productname = string.Format("Product {0}", i+1);
                    products[i].name = productname;
                    products[i].id = i;
                    products[i].price = 2500;
                    Console.WriteLine("Book: (id={0},name='{1}',price={2}) - computeTax = {3}", products[i].id, products[i].name, products[i].price, products[i].computeTax());
                }
                else {

                    products[i] = new Phone();
                    productname = string.Format("Product {0}", i+1);
                    products[i].name = productname;
                    products[i].id = i;
                    products[i].price = 5000;
                    Console.WriteLine("Phone: (id={0},name='{1}',price={2}) - computeTax = {3}", products[i].id, products[i].name, products[i].price, products[i].computeTax());

                }
            }
        }
    }
}
