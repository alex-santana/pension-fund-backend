using Alex.Developer.Pension.Funds.Domain.Enums;
using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class PensionFundAccount : Entity
    {
        public PensionFundAccount(Name name, bool special, bool optional, EPensionFundAccountType accountType, EPensionFundAccountResponsable accountResponsable, EPensionFundAccountGroup accountGroup)
        {
            Name = name;
            Special = special;
            Optional = optional;
            AccountType = accountType;
            AccountResponsable = accountResponsable;
            AccountGroup = accountGroup;

            //TODO: validations
        }

        public Name Name{ get; private set; }
        public bool Special { get; private set; }
        public bool Optional { get; private set; }
        public EPensionFundAccountType AccountType { get; private set; }
        public EPensionFundAccountResponsable AccountResponsable { get; private set; }
        public EPensionFundAccountGroup AccountGroup { get; private set; }

        public decimal PercentMinContribuition { get; private set; }
        public decimal PercentMaxContribuition { get; private set; }
        public decimal PercentIncrementContribuition { get; private set; }

        public Plan Plan { get; private set; }
    }
}
