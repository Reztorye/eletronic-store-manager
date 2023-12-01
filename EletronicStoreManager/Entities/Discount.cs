using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Discount
    {
        private int IdUp {  get; set; }
        private int IdDiscount { get; set; }
        private string DiscountType { get; set; }
        //private Product product { get; set; }
        private DateTime BeginDate { get; set; }
        private DateTime EndDate { get; set; }

        public Discount(string discountType, DateTime beginDate, DateTime endDate)
        {   
            IdDiscount = 1 + IdUp++;
            DiscountType = discountType;
            BeginDate = beginDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return "[ID do Desconto: " + IdDiscount + " | Tipo do Desconto: " + DiscountType + " | Data de Inicio : " + BeginDate + " | Data de Fim: " + EndDate + "]"; 
         }
    }
}
