using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Cart
    {
        public static int UpId = 1;
        public int CartId { get; private set; }
        public int CustomerId { get; private set; }
        public DateTime CreationDate {  get; private set; }
        public List<ItemsCart> Items { get; private set; }
        public double TotalAmount { get; private set; }

        public Cart(Customer customerId, DateTime creationDate, 
            List<ItemsCart> items)
        {
            CartId = UpId++;
            CustomerId = customerId.CustomerId;
            CreationDate = creationDate;
            Items = items ?? new List<ItemsCart>();
            Calcular();
        }

        public void Calcular()
        {   
            TotalAmount = 0;
            foreach( var item in Items)
            {
                TotalAmount += item.TotalPrice;
                
            }
        } 
    }
}
