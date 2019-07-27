using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Company : Entity
    {
        public Company(Name name, Document document, Email email, Address address, BankAccount bankAccount)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            BankAccount = bankAccount;
            _sponsors = new List<Sponsor>();

            AddNotifications(name, document, email, address, bankAccount);

        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public BankAccount BankAccount { get; private set; }
        public IReadOnlyCollection<Sponsor> Sponsors { get { return _sponsors.ToArray(); } }
        private IList<Sponsor> _sponsors;

        public void AddSponsor(Sponsor sponsor)
        {
            var hasSponsorActive = false;
            foreach (var sponsoritem in _sponsors)
            {
                if (sponsoritem.Active)
                    hasSponsorActive = true;
            }

            AddNotifications(new Contract()
            .Requires()
            .IsFalse(hasSponsorActive, "Company.Sponsors", $"A entidade {Name.NameField} já possui a patrocinadora {sponsor.Name}")
            );

            _sponsors.Add(sponsor);

        }
    }
}
