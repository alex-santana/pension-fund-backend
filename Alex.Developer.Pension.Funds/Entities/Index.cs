using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Index
    {
        public Index(Name name, decimal value, string anomes, Date date)
        {
            Name = name;
            Value = value;
            this.anomes = anomes;
            Date = date;

            //TODO: validations
        }

        public Name Name { get; private set; }
        public decimal Value { get; private set; }
        public string anomes { get; private set; }
        public Date  Date { get; private set; }
    }
}
