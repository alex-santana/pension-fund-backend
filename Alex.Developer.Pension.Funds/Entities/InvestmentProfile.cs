using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class InvestmentProfile : Entity
    {
        public InvestmentProfile(Name name, int maxAge)
        {
            Name = name;
            MaxAge = maxAge;
            Active = false;
        }

        public Name Name{ get; private set; }
        public int MaxAge { get; private set; }
        public bool Active { get; private set; }
    }
}
