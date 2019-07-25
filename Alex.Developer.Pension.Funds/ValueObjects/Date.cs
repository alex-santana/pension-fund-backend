using Alex.Developer.Pension.Funds.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.ValueObjects
{
    public class Date : ValueObject
    {
        public DateTime Inclusion { get; private set; }
        public DateTime Alteracion { get; private set; }
    }
}
