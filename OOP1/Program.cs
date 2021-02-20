using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Komputer";
            product1.UnitPrice = 5000;
            product1.UnitsInStock = 25;

            Product product2 = new Product { Id = 2, CategoryId = 3, UnitsInStock = 5, ProductName = "Notebook", UnitPrice = 2500 };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            int sayi = 100;
            productManager.BirseyEle(sayi);
            Console.WriteLine(sayi);
        }
    }
}
