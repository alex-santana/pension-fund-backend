using Alex.Developer.Pension.Funds.Domain.Enums;
using Alex.Developer.Pension.Funds.Shared.Commands;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Commands.AdhseionCommands.Inputs
{
    public class CreateAdhseionCommand: Notifiable, ICommand
    {
        public Guid Id { get; set; }
        public string CompanyId { get;  set; }
        public string SponsorId { get;  set; }
        public string PlanId { get;  set; }
        public string BranchId { get;  set; }
        public string EmployeeId { get;  set; }

        public DateTime Initial { get;  set; }
        public DateTime Admission { get;  set; }
        public DateTime Suspension { get;  set; }
        public DateTime Dismissal { get;  set; }
        public DateTime Inclusion { get; set; }
        public DateTime Alteracion { get; set; }
        public EStatus Status { get;  set; }
        public bool IsRegressive { get;  set; }
        public DateTime? RegressiveDate { get;  set; }

        public bool IsValid()
        {
            return base.Valid;
        }

        //TODO: Fail Fast Validation

    }
}
