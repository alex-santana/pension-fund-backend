using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Sponsor : Entity
    {
        public Name Name { get; set; }
        public IReadOnlyCollection<Branch> Branchs { get { return _branchs.ToArray(); } }
        private IList<Branch> _branchs;

    }
}
