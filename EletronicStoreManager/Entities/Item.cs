using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Item
    {
        public static int UpId {  get; private set; }
        public long SkuItem {  get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public string Color { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public Supplier Supplier { get; private set; }
        public Category Category { get; private set; }
        public int Stock { get; private set; }
        public Boolean Availability { get; private set; }
        public DateTime RegistrationDate {  get; private set; }
        public Warranty Warranty { get; set; } 
        //images?
        public TechnicalSpecifications TechnicalSpecifications { get; set; } 

        //public Item(){}

        public Item(long skuItem, string name, string description, double price, string color, Supplier supplier, 
            Category category, Warranty warranty, int stock, bool availability, DateTime registrationDate)
        {
            SkuItem = skuItem;
            Name = name;
            Description = description;
            Price = price;
            Color = color;
            Supplier = supplier;
            Category = category;
            Warranty = warranty;
            Stock = stock;
            Availability = availability;
            RegistrationDate = registrationDate;        
        }

        public override string ToString()
        {
            return "[SKU do Produto: " + SkuItem
                + " | Nome: " + Name
                + " | Preço: R$ " + Price.ToString("#,##0.00").Replace('.', ',')
                + " | Fornecedor: " + Supplier.Name
                + " | Categoria: " + Category.Name
                + " | Estoque: " + Stock
                + " | Data de entrada: " + RegistrationDate.ToString("dd/MM/yyyy") + "]";
        }
    }
}

