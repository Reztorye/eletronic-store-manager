using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Customer
    {
        private int UpId {  get; set; }
        private int CustomerId { get; set; } 
        private string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        private List<string> PurchaseHistory { get; set; }

        public Customer(string name, string address, string phone)
        {
            CustomerId = 1 + UpId++;
            Name = name;
            Address = address;
            Phone = phone;
        }

        public Customer(string name, string address, string phone, List<string> purchaseHistory)
        {
            CustomerId = 1 + UpId++;
            Name = name;
            Address = address;
            Phone = phone;
            PurchaseHistory = purchaseHistory;
        }
        

        public override string ToString()
        {
            return "[ID do Cliente: " + CustomerId +  " | Nome do Cliente: " + Name + " | Endereco do Cliente: " + Address + " | Telefone do Cliente:  " + Phone + "]";
        }
    }
}
