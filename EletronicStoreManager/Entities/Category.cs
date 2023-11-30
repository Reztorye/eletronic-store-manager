using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Category
    {
        private int UpId {  get; set; }
        private int CategoryId {  get; set; }
        private string CategoryName { get; set; }

        public Category(string categoryName)
        {
            CategoryId = 1 + UpId++;
            CategoryName = categoryName;
        }

        public override string ToString()
        {
            return "[ID da Categoria: " + CategoryId + " | Nome da Categoria: " + CategoryName + "]";
        }
    }
}
