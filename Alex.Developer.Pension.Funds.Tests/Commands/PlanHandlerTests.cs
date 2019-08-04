using Alex.Developer.Pension.Funds.Domain.Commands.PlanCommands.Inputs;
using Alex.Developer.Pension.Funds.Domain.Handlers;
using Alex.Developer.Pension.Funds.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Tests.Commands
{
    [TestClass]
    public class PlanHandlerTests
    {
        [TestMethod]
        public void ShouldRegisterPlanWhenPlanIsValid() {

            var commandPlan = new CreatePlanCommand();
            commandPlan.Id = Guid.NewGuid();
            commandPlan.NameField = "Plano de Aposentadoria AlphaPrev";
            commandPlan.Abreviation = "AlphaPrev";
            commandPlan.Description = "Plano Criado para os empregados da empresa Alpha";
            commandPlan.Active = true;
            commandPlan.Cnpb = 4598483201;
            commandPlan.AmountAnnualBenefits = 12;
            commandPlan.AmountAnnualContributions = 12;
            commandPlan.CountEmployeeContribution = false;
            commandPlan.Effecive = DateTime.Now;
            commandPlan.Inclusion = DateTime.Now;
            commandPlan.RegulationNew = true;
            commandPlan.ReservationSpecialVirtual = false;
            commandPlan.SalaryAdjustmentMonth = 2;
            commandPlan.TypePlan = Domain.Enums.EPlanType.Pension;
            commandPlan.MonthlyProcessing = true;

            var handler = new PlanHandler(new FakePlanRepository(), new FakeEmailService());
            var result = handler.Handle(commandPlan);

            Assert.AreNotEqual(null, result);
            Assert.AreEqual(true, handler.Valid);
        }
    }
}
