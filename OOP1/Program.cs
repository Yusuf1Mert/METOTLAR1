using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id= 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStok = 3;

            Product product2 = new Product {Id= 2,CategoryId=5,UnitsInStok=13,ProductName="kalem",UnitPrice=15 };


            //Case sensitive
            //PascalCase     //camelCase

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);



        }
    }
}
