using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Plan : Entity
    {
        public Name Name { get; private set; }
        public Date Date { get; private set; }
        public bool Active { get; private set; }

        public IReadOnlyCollection<Sponsor> Sponsors { get { return _sponsors.ToArray(); } }
        private IList<Sponsor> _sponsors;

        public IReadOnlyCollection<Adhesion> Adhesions { get { return _adhesions.ToArray(); } }
        private IList<Adhesion> _adhesions;
    }
}
