using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Warranty
    {
        public int UpId { get; private set; }
        public int WarrantyId { get; private set; }
        public string WarrantyTerms {  get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set;}
        public Item CoveredItem { get; private set; }

        public Warranty(string warrantyTerms, DateTime startTime, DateTime endTime, Item coveredItem)
        {
            WarrantyId = 1 + UpId++;
            WarrantyTerms = warrantyTerms;
            StartTime = startTime;
            EndTime = endTime;
            CoveredItem = coveredItem;
        }

        public bool IsValid()
        {
            return DateTime.Now < EndTime; 
        }

        public override string ToString()
        {
            return "[ID da Garantia: " + WarrantyId
                + " | Termos: " + WarrantyTerms
                + " | Data de Inicio: " + StartTime.ToString("dd/MM/yyyy")
                + " | Data de Fim: " + EndTime.ToString("dd/MM/yyyy") 
                + " | SKU do item a estar sendo coberto: " + CoveredItem.SkuItem + "]";
        }
    }
}
