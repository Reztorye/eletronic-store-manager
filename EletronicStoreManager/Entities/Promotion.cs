using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicStoreManager.Entities
{
    internal class Promotion
    {
        public int IdUp {  get; private set; }
        public int IdPromotion { get; private set; }
        public Item ItemWithPromotion { get;  set; }
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public double PromotionPercent {  get; private set; }

        public Promotion(Item itemWithPromotion, DateTime beginDate, DateTime endDate, double promotionPercent)
        {
            ApplyPromotion();
            IdPromotion = 1 + IdUp++;
            ItemWithPromotion = itemWithPromotion;
            BeginDate = beginDate;
            EndDate = endDate;
            PromotionPercent = promotionPercent;

            if (DateTime.Now >= BeginDate && DateTime.Now <= EndDate)
            {
                itemWithPromotion.SetDiscountedPrice(CalculateDiscountedPrice());
            }
            else
            {
                throw new InvalidOperationException("A promoção não está ativa na data atual.");
            }
        }

        public void ApplyPromotion()
        {
            if (IsPromotionValid(DateTime.Now))
            {
                ItemWithPromotion.ApplyDiscount(PromotionPercent);
            }
        }

        public bool IsPromotionValid(DateTime currentDate)
        {
            return currentDate >= BeginDate && currentDate <= EndDate;
        }

        private double CalculateDiscountedPrice()
        {
            return ItemWithPromotion.OriginalPrice * (1 - PromotionPercent / 100);
        }

        public override string ToString()
        {
            return "[ID do Desconto: " + IdPromotion 
                +  " | SKU do Produto: " + ItemWithPromotion.SkuItem 
                +  " | Data de Inicio : " + BeginDate 
                +  " | Data de Fim: " + EndDate 
                +  " | Porcentagem de desconto: " +  PromotionPercent + "%]"; 
         }
    }
}
