using System;
using Business1.Concrete;
using DataAccess1.Concrete.EntityFramework;
using DataAccess1.Concrete.InMemory;

namespace ConsoleUI
{
    //SOLİD 
    //Open Closed Principle
    public class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());
            
            foreach (var item in productManager.GetByUnitPrice(5,40))
            {

                Console.WriteLine(item.ProductName);

            }

        }
    }
}