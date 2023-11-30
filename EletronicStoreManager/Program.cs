using EletronicStoreManager.Entities;
using System;
using System.Globalization;

namespace EletronicStoreManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Supplier fornecedor1 = new Supplier("Sony", "email@gmail.com", "(00) 99555-9999");

            Category categoria1 = new Category("Smartphone");

            Customer cliente1 = new Customer("Neymar Jr", "Maldivas - Rua da Luz 1999", "(00) 99555-9999");

            Console.WriteLine(fornecedor1);
            Console.WriteLine(categoria1);
            Console.WriteLine(cliente1);
        }
    }
}