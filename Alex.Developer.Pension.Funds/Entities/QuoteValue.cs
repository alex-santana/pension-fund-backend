using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class QuoteValue : Entity
    {
        public DateTime Valorization { get; set; }
        public decimal GuaranteeValue { get; set; }
        public decimal GrossValue { get; set; }
        public decimal Initialpatrimony { get; set; }
        public decimal Finalpatrimony { get; set; }
    }
}
