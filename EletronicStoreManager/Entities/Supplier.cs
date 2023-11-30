using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Supplier
    {   
        private static int upId {  get; set; }
        private int SupplierId {  get; set; }
        private string SupplierName { get; set;}
        private string SupplierEmail { get; set; }
        private string SupplierPhone {  get; set; }

        public Supplier (string supplierName, string supplierEmail, string supplierPhone)
        {   
            SupplierId = 1 + upId++;
            SupplierName = supplierName;
            SupplierEmail = supplierEmail;
            SupplierPhone = supplierPhone;
        }

        public override string ToString()
        {
            return "[ID do Fornecedor: " + SupplierId + " | Nome do Fornecedor: " + SupplierName + " | E-mail do Fornecedor: " + SupplierEmail + " | Telefone do Fornecedor: " + SupplierPhone + "]";
        }

    }
}
