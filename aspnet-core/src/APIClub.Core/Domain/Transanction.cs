using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIClub.Domain
{
    public class Transanction : FullAuditedEntity
    {
        public Stock Stock { get; set; }

        public DateTime Date { get; set; }

        public TransactionType Type { get; set; }

        public float Quantity { get; set; }

        public float Price { get; set; }
    }

    public enum TransactionType
    {
        Buy = 0,
        Sell = 0
    }
}
