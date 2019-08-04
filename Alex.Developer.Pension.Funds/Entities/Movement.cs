using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Movement : Entity
    {
        public Movement(string adhesionId, DateTime movementDate, DateTime cashDate, decimal value, char signal, string yearMonth, decimal quoteTotal, decimal guaranteeQuote, int? installment)
        {
            AdhesionId = adhesionId;
            MovementDate = movementDate;
            CashDate = cashDate;
            Value = value;
            Signal = signal;
            YearMonth = yearMonth;
            QuoteTotal = quoteTotal;
            GuaranteeQuote = guaranteeQuote;
            Installment = installment;

            //TODO: validations
        }

        public string AdhesionId { get; private set; }
        public DateTime MovementDate { get; private set; }
        public DateTime CashDate { get; private set; }
        public decimal Value { get; private set; }
        public char Signal { get; private set; }
        public string YearMonth { get; private set; }
        public decimal QuoteTotal { get; private set; }
        public decimal GuaranteeQuote { get; private set; }
        public int? Installment { get; private set; }




    }
}
