using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Product : Entity
    {
        public Name Name { get; private set; }
        public IReadOnlyCollection<Plan> Plans { get { return _plans.ToArray(); } }
        private IList<Plan> _plans;
    }
}
