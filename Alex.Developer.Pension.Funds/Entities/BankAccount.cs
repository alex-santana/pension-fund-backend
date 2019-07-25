using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class BankAccount : Entity
    {
        public Guid ParticipantID { get; private set; }
        public int BankCode { get; private set; }
        public int AgencyNumber { get; private set; }
        public int AgencyDigit { get; private set; }
        public int AccountNumber { get; private set; }
        public int AccountDigit { get; private set; }
        public Date Date { get; private set; }
    }
}
