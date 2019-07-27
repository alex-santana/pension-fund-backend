using Alex.Developer.Pension.Funds.Shared.ValueObjects;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string complement, int number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Complement = complement;
            this.number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract().Requires()
            .HasMinLen(street, 10, "Address.Street", "Rua deve ter ao menos 5 caracteres")
            .HasMaxLen(street, 100, "Address.Street", "Rua deve ter no máximo 100 caracteres")
            .HasMinLengthIfNotNullOrEmpty(complement, 5, "Address.Complement", "O complemento deve ter ao menos 5 caracteres")
            .HasMaxLengthIfNotNullOrEmpty(complement, 150, "Address.Complement", "O complemento deve ter no máximo 150 caracteres")
            .HasMinLen(neighborhood, 5, "Address.Neighborhood", "Bairro deve ter ao menos 5 caracteres")
            .HasMaxLen(neighborhood, 100, "Address.Neighborhood", "Bairro deve ter no máximo 100 caracteres")
            .HasMinLen(city, 5, "Address.City", "Cidade deve ter ao menos 5 caracteres")
            .HasMaxLen(city, 100, "Address.City", "Cidade deve ter no máximo 100 caracteres")
            .HasLen(state, 2, "Address.State", "Estado inválido")
            .HasMinLen(country, 5, "Address.Country", "Rua deve ter ao menos 5 caracteres")
            .HasMaxLen(country, 100, "Address.Country", "Rua deve ter no máximo 100 caracteres")
            .HasLen(zipCode, 8, "Address.ZipCode", "Rua deve ter ao menos 5 caracteres")
            );


        }

        public string Street { get; private set; }
        public string Complement { get; private set; }
        public int number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}
