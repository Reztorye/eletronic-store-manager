using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Category
    {
        public static int UpId {  get; private set; }
        public int CategoryId {  get; private set; }
        public string Name { get; private set; }

        public Category(string name)
        {
            CategoryId = 1 + UpId++;
            Name = name;
        }

        public override string ToString()
        {
            return "[ID da Categoria: " + CategoryId 
                + " | Nome da Categoria: " + Name + "]";
        }
    }
}
