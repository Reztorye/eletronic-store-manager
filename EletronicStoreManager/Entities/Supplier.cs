using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Supplier
    {   
        public static int upId {  get; private set; }
        public int SupplierId {  get; private set; }
        public string Name { get; private set;}
        public string Email { get; private set; }
        public string Phone {  get; private set; }

        public Supplier (string name, string email, string phone)
        {   
            SupplierId = 1 + upId++;
            Name = name;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return "[ID do Fornecedor: " + SupplierId 
                + " | Nome: " + Name 
                + " | E-mail: " + Email 
                + " | Telefone: " + Phone + "]";
        }
    }
}
