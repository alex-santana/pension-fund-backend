using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Employee : Entity
    {
        public Name Name { get; set; }
        public Document CPF { get; set; }
        public DateTime Birth { get; set; }
        public Email Email { get; set; }
        public BankAccount BankAccount { get; private set; }
        public Address Address { get; private set; }
        public Date Date { get; private set; }

        private IList<Adhesion> _adhesions;
        public IReadOnlyCollection<Adhesion> Adhesions { get { return _adhesions.ToArray(); } }
    }
}