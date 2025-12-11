using System;
using Business1.Concrete;
using DataAccess1.Concrete.EntityFramework;
using DataAccess1.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    //SOLİD 
    //Open Closed Principle
    public class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
            //IoC
            ProductTest();
            CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}