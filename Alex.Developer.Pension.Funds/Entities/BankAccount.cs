using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class BankAccount : Entity
    {
        public BankAccount(int bankCode, 
            int agencyNumber, 
            int agencyDigit, 
            int accountNumber, 
            int accountDigit, 
            Date date)
        {
            BankCode = bankCode;
            AgencyNumber = agencyNumber;
            AgencyDigit = agencyDigit;
            AccountNumber = accountNumber;
            AccountDigit = accountDigit;
            Date = date;

            //TODO: notificações
            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(bankCode, 0, "BankAccount.BankCode", "Código do banco inválido")
                .IsGreaterThan(bankCode, 0, "BankAccount.AgencyNumber", "Agência inválida")
                .IsGreaterThan(bankCode, 0, "BankAccount.AgencyDigit", "Dígito da agência inválido")
                .IsGreaterThan(bankCode, 0, "BankAccount.AccountNumber", "Conta inválida")
                .IsGreaterThan(bankCode, 0, "BankAccount.AccountDigit", "Dígito da conta inválida")
                );
        }

        public int BankCode { get; private set; }
        public int AgencyNumber { get; private set; }
        public int AgencyDigit { get; private set; }
        public int AccountNumber { get; private set; }
        public int AccountDigit { get; private set; }
        public Date Date { get; private set; }
    }
}
