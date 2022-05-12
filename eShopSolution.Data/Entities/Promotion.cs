using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Fromdate { get; set; }

        public DateTime Todate { get; set; }

        public PromotionStatus Status { get; set; }


     }


}
