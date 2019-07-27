using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Participant : Entity
    {
        public Name Name { get; private set; }
        public Document CPF { get; private set; }
        public DateTime Birth { get; private set; }
        public string Email { get; private set; }
        public BankAccount BankAccount { get; private set; }
        public Date Date { get; private set; }

        public Adhesion Adhesion { get; private set; }
    }
}
