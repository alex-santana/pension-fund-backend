using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Movement : Entity
    {
        public DateTime MovementDate { get; set; }
        public decimal Value { get; set; }
        public char Signal { get; set; }
        public string YearMonth { get; set; }
        public string Responsable { get; set; }

    }
}
