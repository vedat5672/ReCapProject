using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var item in productManager.GetAllByCarID(2))
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
