using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Cart
    {
        public static int UpId = 1;
        public int CartId { get; private set; }
        public Customer Customer { get; private set; }
        public DateTime CreationDate {  get; private set; }
        public List<ItemsCart> Items { get; private set; }
        public double TotalAmount { get; private set; }


        public Cart(Customer customer, DateTime creationDate, List<ItemsCart> items)
        {
            CartId = UpId++;
            Customer = customer;
            CreationDate = creationDate;
            Items = items ?? new List<ItemsCart>();
            CalculateTotal();
        }

        public override string ToString()
        {
            string totalFormatado = TotalAmount.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            return "[ID do Carrinho: " + CartId
                + " | Carrinho do Cliente: " + Customer.Name
                + " | Data de criacao:  " + CreationDate.ToString("dd/MM/yyyy")
                + " | SKU dos items: " + PrintItems() + " | Total do carrinho: " + totalFormatado + "]";
        }

        public void AddItem(ItemsCart cart)
        {
            Items.Add(cart);
            CalculateTotal();
        }

        public string PrintItems()
        {
            string itemsString = ""; 
            bool primeiroItem = true; 

            foreach (var item in Items) 
            {
                if (!primeiroItem) 
                {
                    itemsString += ", "; 
                }
                itemsString += item.SKUItem.ToString(); 
                primeiroItem = false; 
            }
            return itemsString;
        }

        public void CalculateTotal()
        {
            TotalAmount = 0;
            foreach (var item in Items)
            {
                TotalAmount += item.Item.Price * item.Quantity;
            }
        }
    }
}
