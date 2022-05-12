using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Oder
    {
        public int Id { get; set; }
        public DateTime   OrderDate { get; set; }
        public int UserId { get; set; }
        public OderStatus Status { get; set; }


    }
}
