using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class TechnicalSpecifications
    {   
        public int IdUp { get; set; }
        public int IdTechnicalSpecifications { get; set; }
        public string PowerType { get; set; }
        public string EnergyConsumption { get; set; }
        public string Connectivity { get; set; }
        public string Resolution { get; set; }
        public string OperationRange {  get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Certifications {  get; set; }
        public double Weight { get; set; }
        public string Dimension { get; set; }
        public Item SpecifiedItem { get; set; }

        public TechnicalSpecifications(string powerType, string energyConsumption, string connectivity, string resolution, 
            string operationRange, DateTime releaseDate, string certifications, double weight, string dimension, Item specifiedItem)
        {
            IdTechnicalSpecifications = 1 + IdUp++;
            PowerType = powerType;
            EnergyConsumption = energyConsumption;
            Connectivity = connectivity;
            Resolution = resolution;
            OperationRange = operationRange;
            ReleaseDate = releaseDate;
            Certifications = certifications;
            Weight = weight;
            Dimension = dimension;
            SpecifiedItem = specifiedItem;
        }

        public override string ToString()
        {
            return "[SKU do produto especificado: " + SpecifiedItem.SkuItem
                + " | Tipo de energia: " + PowerType
                + " | Consumo de energia: " + EnergyConsumption
                + " | Conectividade: " + Connectivity + "\n"
                + " | Resolução: " + Resolution 
                + " | Alcance de Operação: " + OperationRange 
                + " | Data de Lançamento: " + ReleaseDate.ToString("dd/MM/yyyy")
                + " | Certificações: " + Certifications
                + " | Peso: " + Weight
                + " | Dimensão: " + Dimension
                + "]";
        }
    }
}
