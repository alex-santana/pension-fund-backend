using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.ValueObjects
{
    public class Name
    {
        public Name(string nameField, string abreviation, string description)
        {
            NameField = nameField;
            Abreviation = abreviation;
            Description = description;
        }

        public string NameField { get; private set; }
        public string Abreviation { get; private set; }
        public string Description { get; private set; }
    }
}
