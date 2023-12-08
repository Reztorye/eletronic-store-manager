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

            // Mais três novos produtos
            Item xboxSeriesX = new Item(2, "Xbox Series X", "1TB", 4500.00, "Preto", fornecedor1,
                         categoria1, null, 10, true, DateTime.Parse("2023-10-20"));

            Item nintendoSwitch = new Item(3, "Nintendo Switch", "32GB", 3000.00, "Vermelho e Azul", fornecedor1,
                         categoria1, null, 20, true, DateTime.Parse("2023-10-20"));

            Item playstation4 = new Item(4, "Playstation 4", "1TB", 2500.00, "Branco", fornecedor1,
                         categoria1, null, 5, true, DateTime.Parse("2023-10-20"));

            Warranty garantiaNovoItem = new Warranty("Esta garantia cobre defeitos de fabricação ou falhas no " + novoItem.Name + " sob condições normais de uso.",
                                                     DateTime.Parse("2023-10-20"),
                                                     DateTime.Parse("2024-10-20"),
                                                     novoItem);

            TechnicalSpecifications technicalSpecificationsPS5 = new TechnicalSpecifications("AC 100-240V, 50/60Hz", "Approx. 340W",
                                                                                            "Ethernet, IEEE 802.11 a/b/g/n/ac/ax, Bluetooth 5.1",
                                                                                            "4K 120Hz, 8K, VRR (HDMI 2.1)", "N/A", DateTime.Parse("2020, 11, 19"),
                                                                                            "CE, FCC", 4, "358 x 80 x 216 mm", novoItem);

            Warranty garantiaPS5 = new Warranty("Esta garantia cobre defeitos de fabricação ou falhas no Playstation 5 sob condições normais de uso.",
                                                DateTime.Parse("2023-10-20"),
                                                DateTime.Parse("2024-10-20"),
                                                novoItem);

            Warranty garantiaXboxSeriesX = new Warranty("Esta garantia cobre defeitos de fabricação ou falhas no Xbox Series X sob condições normais de uso.",
                                                        DateTime.Parse("2023-10-20"),
                                                        DateTime.Parse("2024-10-20"),
                                                        xboxSeriesX);

            Warranty garantiaNintendoSwitch = new Warranty("Esta garantia cobre defeitos de fabricação ou falhas no Nintendo Switch sob condições normais de uso.",
                                                           DateTime.Parse("2023-10-20"),
                                                           DateTime.Parse("2024-10-20"),
                                                           nintendoSwitch);

            Warranty garantiaPS4 = new Warranty("Esta garantia cobre defeitos de fabricação ou falhas no Playstation 4 sob condições normais de uso.",
                                                DateTime.Parse("2023-10-20"),
                                                DateTime.Parse("2024-10-20"),
                                                playstation4);


            TechnicalSpecifications specsPS5 = new TechnicalSpecifications(
                "AC 100-240V, 50/60Hz",
                "Approx. 340W",
                "Ethernet, IEEE 802.11 a/b/g/n/ac/ax, Bluetooth 5.1",
                "4K 120Hz, 8K, VRR (HDMI 2.1)",
                "N/A",
                DateTime.Parse("2020-11-19"),
                "CE, FCC",
                4.0,
                "358 x 80 x 216 mm",
                novoItem);

            TechnicalSpecifications specsXboxSeriesX = new TechnicalSpecifications(
                "AC 100-240V, 50/60Hz",
                "Approx. 300W",
                "Ethernet, IEEE 802.11 a/b/g/n/ac/ax, Bluetooth 5.0",
                "4K 120Hz, 8K",
                "N/A",
                DateTime.Parse("2020-11-10"),
                "CE, FCC",
                4.45,
                "301 x 151 x 151 mm",
                xboxSeriesX);

            TechnicalSpecifications specsNintendoSwitch = new TechnicalSpecifications(
                "AC 100-240V, 50/60Hz",
                "Approx. 39W",
                "Wi-Fi (IEEE 802.11 a/b/g/n/ac), Bluetooth 4.1",
                "720p 30Hz",
                "N/A",
                DateTime.Parse("2017-03-03"),
                "CE, FCC",
                0.88,
                "239 x 102 x 13.9 mm",
                nintendoSwitch);

            TechnicalSpecifications specsPS4 = new TechnicalSpecifications(
                "AC 100-240V, 50/60Hz",
                "Approx. 165W",
                "Ethernet, IEEE 802.11 a/b/g/n/ac, Bluetooth 4.0",
                "1080p 60Hz",
                "N/A",
                DateTime.Parse("2013-11-15"),
                "CE, FCC",
                2.8,
                "265 x 39 x 288 mm",
                playstation4);

            novoItem.Warranty = garantiaPS5;
            novoItem.TechnicalSpecifications = specsPS5;

            xboxSeriesX.Warranty = garantiaXboxSeriesX;
            xboxSeriesX.TechnicalSpecifications = specsXboxSeriesX;

            nintendoSwitch.Warranty = garantiaNintendoSwitch;
            nintendoSwitch.TechnicalSpecifications = specsNintendoSwitch;

            playstation4.Warranty = garantiaPS4;
            playstation4.TechnicalSpecifications = specsPS4;

            Promotion promotion1 = new Promotion(novoItem, DateTime.Parse("2023-10-20"), DateTime.Parse("2023-12-27"), 50);
            promotion1.ApplyPromotion();

            novoItem.TechnicalSpecifications = technicalSpecificationsPS5;
            novoItem.Warranty = garantiaNovoItem;

            ItemsCart itemsCarrinhoNeymar = new ItemsCart(novoItem, 4);
            ItemsCart itemsCarrinhoNeymarItem2 = new ItemsCart(nintendoSwitch, 10);

            Cart carrinhoNeymar = new Cart(cliente1, DateTime.Now, new List<ItemsCart>());
            carrinhoNeymar.AddItem(itemsCarrinhoNeymar);
            carrinhoNeymar.AddItem(itemsCarrinhoNeymarItem2);

            Console.WriteLine(novoItem);
            Console.WriteLine("\n");
            Console.WriteLine(garantiaPS5);
            Console.WriteLine("\n");
            Console.WriteLine(specsPS5);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(xboxSeriesX);
            Console.WriteLine("\n");
            Console.WriteLine(garantiaXboxSeriesX);
            Console.WriteLine("\n");
            Console.WriteLine(specsXboxSeriesX);
            Console.WriteLine("\n");
            Console.WriteLine("\n");        
            Console.WriteLine(nintendoSwitch);
            Console.WriteLine("\n");
            Console.WriteLine(garantiaNintendoSwitch);
            Console.WriteLine("\n");
            Console.WriteLine(specsNintendoSwitch);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(playstation4);
            Console.WriteLine("\n");
            Console.WriteLine(garantiaPS4);
            Console.WriteLine("\n");
            Console.WriteLine(specsPS4);
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            Console.WriteLine(promotion1);
            Console.WriteLine("\n");

            Console.WriteLine(carrinhoNeymar);
            Console.WriteLine("\n");


            foreach (var itemCart in carrinhoNeymar.Items)
            {
                Console.WriteLine(itemCart);
                Console.WriteLine("\n");
            }
        }
    }
}
