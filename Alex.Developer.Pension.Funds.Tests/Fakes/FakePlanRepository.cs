using Alex.Developer.Pension.Funds.Domain.Entities;
using Alex.Developer.Pension.Funds.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Tests.Fakes
{
    public class FakePlanRepository : IPlanRepository
    {
        public bool CheckPlan(long cnpb)
        {
            return true;
        }

        public void Save(Plan plan)
        {
            
        }
    }
}
