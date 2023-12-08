using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Customer
    {
        public int UpId {  get; private set; }
        public int CustomerId { get; private set; } 
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        //public List<string> PurchaseHistory { get; private set; }

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
            //PurchaseHistory = purchaseHistory;
        }
        

        public override string ToString()
        {
            return "[ID do Cliente: " + CustomerId 
                +  " | Nome do Cliente: " + Name 
                + " | Endereco do Cliente: " + Address 
                + " | Telefone do Cliente:  " + Phone + "]";
        }
    }
}
