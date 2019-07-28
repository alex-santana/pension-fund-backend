using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Employee : Entity
    {
        public Employee(Name name, Document cPF, DateTime birth, Email email, BankAccount bankAccount, Address address, Phone phone, Date date, bool isPoliticallyExposedPerson, DateTime? datePoliticalExposition)
        {
            Name = name;
            CPF = cPF;
            Birth = birth;
            Email = email;
            BankAccount = bankAccount;
            Address = address;
            Phone = phone;
            Date = date;

            //TODO: Metodo para analisar PPE
            //IsPoliticallyExposedPerson = isPoliticallyExposedPerson;
            //DatePoliticalExposition = datePoliticalExposition;

            _adhesions = new List<Adhesion>();

        }
        public Name Name { get; set; }
        public string FunctionalCode { get; private set; }
        public Document CPF { get; set; }
        public DateTime Birth { get; set; }
        public Email Email { get; set; }
        public BankAccount BankAccount { get; private set; }
        public Address Address { get; private set; }
        public Phone Phone { get; private set; }
        public Date Date { get; private set; }
        public bool IsPoliticallyExposedPerson { get; private set; }
        public DateTime? DatePoliticalExposition { get; private set; }


        private IList<Adhesion> _adhesions;
        public IReadOnlyCollection<Adhesion> Adhesions { get { return _adhesions.ToArray(); } }
    }
}