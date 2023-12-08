using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class ItemsCart
    {
        //public Cart Cart
        public int UpId { get; private set; }
        public int ItemCartId { get; private set; }
        public Item Item { get; private set; }
        public long SKUItem {  get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public double TotalPrice { get; private set; }

        public ItemsCart(Item item, int quantity)
        {
            ItemCartId = 1 + UpId++;
            Item = item;
            SKUItem = item.SkuItem;
            Quantity = quantity;
            Price = item.Price;
            TotalPrice = quantity * item.Price;
        }

        public override string ToString()
        {
            return "[ID do item no carrinho: " + ItemCartId
                + " | SKU do item: " + Item.SkuItem
                + " | Quantidade: " + Quantity
                + " | Preco: " + Price
                + " | Total: " + TotalPrice + "]";
        }

    }
}
