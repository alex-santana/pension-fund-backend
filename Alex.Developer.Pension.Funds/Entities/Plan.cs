using Alex.Developer.Pension.Funds.Domain.Enums;
using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Plan : Entity
    {
        public Name Name { get; private set; }
        public Date Date { get; private set; }
        public EPlanType TypePlan { get; private set; }
        public bool Active { get; private set; }
        public long Cnpb { get; private set; }
        public DateTime Effective { get; private set; }
        public int SalaryAdjustmentMonth { get; private set; }
        public int AmountAnnualContributions { get; private set; }
        public int AmountAnnualBenefits { get; private set; }
        public bool MonthlyProcessing { get; private set; }
        public bool CountEmployeeContribution { get; private set; }
        public bool RegulationNew { get; private set; }
        public bool ReservationSpecialVirtual { get; private set; }
        public bool Required { get; private set; }


        public IReadOnlyCollection<Sponsor> Sponsors{ get { return _sponsors.ToArray(); } }
        private IList<Sponsor> _sponsors;

        public IReadOnlyCollection<Adhesion> Adhesions { get { return _adhesions.ToArray(); } }
        private IList<Adhesion> _adhesions;

        public IReadOnlyCollection<Benefit> Benefits { get { return _benefits.ToArray(); } }
        private IList<Benefit> _benefits;

        public IReadOnlyCollection<PensionFundAccount> PensionFundAccounts { get { return _pensionFundAccounts.ToArray(); } }
        private IList<PensionFundAccount> _pensionFundAccounts;

        public IReadOnlyCollection<InvestmentProfile> InvestmentProfiles { get { return _investmentProfiles.ToArray(); } }
        private IList<InvestmentProfile> _investmentProfiles;

        public IReadOnlyCollection<Employee> Employees { get { return _employees.ToArray(); } }
        private IList<Employee> _employees;

        public Index Index { get; private set; }





    }
}
