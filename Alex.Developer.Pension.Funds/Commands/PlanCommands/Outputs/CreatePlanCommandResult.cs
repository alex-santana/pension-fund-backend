using Alex.Developer.Pension.Funds.Domain.Enums;
using Alex.Developer.Pension.Funds.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Commands.PlanCommands.Outputs
{
    public class CreatePlanCommandResult : ICommandResult
    {
        public CreatePlanCommandResult()
        {

        }
        public CreatePlanCommandResult(Guid id, string companyId, string sponsorId, string planId, string branchId, string employeeId, DateTime initial, DateTime admission, DateTime suspension, DateTime dismissal, DateTime inclusion, DateTime alteracion, EStatus status, bool isRegressive, DateTime? regressiveDate)
        {
            Id = id;
            CompanyId = companyId;
            SponsorId = sponsorId;
            PlanId = planId;
            BranchId = branchId;
            EmployeeId = employeeId;
            Initial = initial;
            Admission = admission;
            Suspension = suspension;
            Dismissal = dismissal;
            Inclusion = inclusion;
            Alteracion = alteracion;
            Status = status;
            IsRegressive = isRegressive;
            RegressiveDate = regressiveDate;
        }

        public Guid Id { get; set; }
        public string CompanyId { get; set; }
        public string SponsorId { get; set; }
        public string PlanId { get; set; }
        public string BranchId { get; set; }
        public string EmployeeId { get; set; }

        public DateTime Initial { get; set; }
        public DateTime Admission { get; set; }
        public DateTime Suspension { get; set; }
        public DateTime Dismissal { get; set; }
        public DateTime Inclusion { get; set; }
        public DateTime Alteracion { get; set; }
        public EStatus Status { get; set; }
        public bool IsRegressive { get; set; }
        public DateTime? RegressiveDate { get; set; }
    }
}
