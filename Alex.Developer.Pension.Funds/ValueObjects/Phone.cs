using Alex.Developer.Pension.Funds.Domain.Enums;
using Alex.Developer.Pension.Funds.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.ValueObjects
{
    public class Phone : ValueObject
    {
        public Phone(string number, EPhoneType phoneType, bool isSmsActive, bool isPhoneDefault)
        {
            Number = number;
            //TODO: Analisar o tipo do telefone para ativar ou não SMS
            PhoneType = phoneType;
            IsSmsActive = isSmsActive;
            IsPhoneDefault = isPhoneDefault;
        }

        public string Number { get; private set; }
        public EPhoneType PhoneType { get; private set; }

        public bool IsSmsActive { get; private set; }
        public bool IsPhoneDefault { get; private set; }
    }
}
