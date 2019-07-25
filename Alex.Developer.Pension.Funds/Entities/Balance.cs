using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Balance : Entity
    {
        public decimal QuoteTotal { get; set; }
        public decimal GuaranteeQuote { get; set; }
    }
}
