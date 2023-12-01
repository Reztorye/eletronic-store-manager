using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Item
    {
        private int UpId {  get; set; }
        private int IdItem {  get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }
        private string Color { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private Category Category { get; set; }
        private int Stock {  get; set; }
        private Boolean Availability { get; set; }
        private DateTime RegistrationDate {  get; set; }
        //private Warranty Warranty { get; set; }
        //private List<Reviews> Reviews { get; set; } 
        //images?
        //private TechnicalSpecifications TechnicalSpecifications { get; set; } 
        //private Dimensions Dimensions { get; set; }
        private double Weight { get; set; }

        public Item(){}

        public Item(string name, string description, double price,
                    int stock, bool availability, DateTime registrationDate)
        {
            IdItem = 1 + UpId++;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Availability = availability;
            RegistrationDate = registrationDate;
        }

        public override string ToString()
        {
            return "[ID do Produto:" + IdItem 
                + " | Nome do Produto: " + Name 
                + " | Preco do Produto: " + Price 
                + " | Estoque do Produto: " + Stock 
                + " | Data de entrada do Produto: " + RegistrationDate + "]";
        }
    }
}

