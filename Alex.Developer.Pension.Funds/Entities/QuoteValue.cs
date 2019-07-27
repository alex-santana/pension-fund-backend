using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class QuoteValue : Entity
    {
        public DateTime Valorization { get; private set; }
        public decimal GuaranteeValue { get; private set; }
        public decimal GrossValue { get; private set; }
        public decimal Initialpatrimony { get; private set; }
        public decimal Finalpatrimony { get; private set; }
    }
}
