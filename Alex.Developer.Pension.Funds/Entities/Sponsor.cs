using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Sponsor : Entity
    {
        public Sponsor(Name name, BankAccount bankAccount, bool active)
        {
            Name = name;
            BankAccount = bankAccount;
            Active = active;
            _plans = new List<Plan>();
            _branchs = new List<Branch>();

            //TODO: validations
        }

        public Name Name { get; private set; }
        public BankAccount BankAccount { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Plan> Plans { get { return _plans.ToArray(); } }
        private IList<Plan> _plans;
        public IReadOnlyCollection<Branch> Branchs { get { return _branchs.ToArray(); } }
        private IList<Branch> _branchs;

        
    }
}
