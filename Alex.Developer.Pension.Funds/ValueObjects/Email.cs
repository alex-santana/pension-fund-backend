using Alex.Developer.Pension.Funds.Shared.ValueObjects;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(
                new Contract()
                .Requires()
                .IsEmail(Address, "Email.Address", "E-mail inválido")
            );
            
        }
        public string Address { get; private set; }
    }
}
