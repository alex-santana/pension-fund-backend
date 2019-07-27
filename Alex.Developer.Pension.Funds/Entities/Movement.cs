using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Movement : Entity
    {
        public string AdhesionId { get; private set; }
        public DateTime MovementDate { get; private set; }
        public decimal Value { get; private set; }
        public char Signal { get; private set; }
        public string YearMonth { get; private set; }
        

    }
}
