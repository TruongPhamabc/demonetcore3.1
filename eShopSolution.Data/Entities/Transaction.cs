using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Transaction
    {
        public int Id { get; set; }

        public int TransactionDate { get; set; }

        public int ExternalTransactionId { get; set; }

        public int Status { get; set; }


    }
}
