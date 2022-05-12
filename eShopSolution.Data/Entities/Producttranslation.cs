using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Producttranslation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ProductId { get; set; }

        public int LanguageId { get; set; }
    }
}
