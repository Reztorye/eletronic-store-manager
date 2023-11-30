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
            Supplier fornecedor1 = new Supplier("Sony", "domruan333@gmail.com", "(41) 99555-7331");
            Supplier fornecedor2 = new Supplier("Sony", "domruan333@gmail.com", "(41) 99555-7331");

            Category categoria1 = new Category("Smartphone");

            Console.WriteLine(fornecedor1);
            Console.WriteLine(fornecedor2);
            Console.WriteLine(categoria1);
        }
    }
}