using Alex.Developer.Pension.Funds.Domain.Enums;
using Alex.Developer.Pension.Funds.Shared.Commands;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Commands.PlanCommands.Inputs
{
    public class CreatePlanCommand : Notifiable, ICommand
    {
        public Guid Id { get; set; }
        public string NameField { get; set; }
        public string Abreviation { get; set; }
        public string Description { get; set; }
        public DateTime Inclusion { get; set; }
        public DateTime Alteracion { get; set; }
        public EPlanType TypePlan { get; set; }
        public bool Active { get; set; }
        public long Cnpb { get; set; }
        public DateTime Effecive { get; set; }
        public int SalaryAdjustmentMonth { get; set; }
        public int AmountAnnualContributions { get; set; }
        public int AmountAnnualBenefits { get; set; }
        public bool MonthlyProcessing { get; set; }
        public bool CountEmployeeContribution { get; set; }
        public bool RegulationNew { get; set; }
        public bool ReservationSpecialVirtual { get; set; }
        public bool Required { get; set; }

        public bool IsValid()
        {
            //Fail Fast Validation
            return Valid;
        }
    }
}
