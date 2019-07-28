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

        public Quote(Name name, Date date, bool active)
        {
            Name = name;
            Date = date;
            Active = active;
            _quoteValue = new List<QuoteValue>();

            //TODO: validations
        }
        public Name Name { get; private set; }
        public Date Date { get; private set; }
        public bool Active { get; private set; }
        private IList<QuoteValue> _quoteValue;
        public IReadOnlyCollection<QuoteValue> QuoteValues { get { return _quoteValue.ToArray(); } }



    }
}
