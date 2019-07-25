using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Quote : Entity
    {
        public Name Name { get; set; }
        public Date Date { get; set; }
        private IList<QuoteValue> _quoteValue;
        public IReadOnlyCollection<QuoteValue> QuoteValues { get { return _quoteValue.ToArray(); } }



    }
}
