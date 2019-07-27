using Alex.Developer.Pension.Funds.Shared.ValueObjects;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string nameField, string abreviation, string description)
        {
            NameField = nameField;
            Abreviation = abreviation;
            Description = description;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(NameField, 5, "Name.NameField", "O Nome deverá ter ao menos 5 caracteres")
                .HasMaxLen(NameField, 100, "Name.NameField", "O Nome deverá ter no máximo 100 caracteres")
                .HasMaxLengthIfNotNullOrEmpty(Abreviation, 100, "Name.Abreviation", "O Nome deverá ter no máximo 100 caracteres")
                .HasMaxLengthIfNotNullOrEmpty(Description, 250, "Name.Abreviation", "O Nome deverá ter no máximo 250 caracteres")
            );
        }

        public string NameField { get; private set; }
        public string Abreviation { get; private set; }
        public string Description { get; private set; }
    }
}
