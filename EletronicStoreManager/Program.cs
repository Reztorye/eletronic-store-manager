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

            Item novoItem = new Item(1, "Playstation 5", "512gb", 5000.00, "Branco", fornecedor1,
                         categoria1, null, 15, true, DateTime.Parse("2023-10-20"));

            Warranty garantiaNovoItem = new Warranty("Esta garantia cobre defeitos de fabricação ou falhas no " + novoItem.Name + " sob condições normais de uso.",
                                                     DateTime.Parse("2023-10-20"),
                                                     DateTime.Parse("2024-10-20"),
                                                     novoItem);

            TechnicalSpecifications technicalSpecificationsPS5 = new TechnicalSpecifications("AC 100-240V, 50/60Hz", "Approx. 340W",
                                                                                            "Ethernet, IEEE 802.11 a/b/g/n/ac/ax, Bluetooth 5.1",
                                                                                            "4K 120Hz, 8K, VRR (HDMI 2.1)", "N/A", DateTime.Parse("2020, 11, 19"),
                                                                                            "CE, FCC", 4, "358 x 80 x 216 mm", novoItem);
           /* {
                PowerType = "AC 100-240V, 50/60Hz",
                EnergyConsumption = "Approx. 340W",
                Connectivity = "Ethernet, IEEE 802.11 a/b/g/n/ac/ax, Bluetooth 5.1",
                OperationRange = "N/A",
                Resolution = "4K 120Hz, 8K, VRR (HDMI 2.1)",
                ReleaseDate = new DateTime(2020, 11, 12),
                Certifications = "CE, FCC",
                Weight = 4,
                Dimension = "358 x 80 x 216 mm"
             };
           */
            novoItem.TechnicalSpecifications = technicalSpecificationsPS5;
            novoItem.Warranty = garantiaNovoItem;


            Console.WriteLine(fornecedor1);
            Console.WriteLine(categoria1);
            Console.WriteLine(cliente1);
            Console.WriteLine(novoItem);
            Console.WriteLine(garantiaNovoItem);
            Console.WriteLine(technicalSpecificationsPS5);
        }
    }
}
