using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Benefit
    {
        public Benefit(Name name, int minAge, int maxAge, int planTime, int serviceTime)
        {
            Name = name;
            MinAge = minAge;
            MaxAge = maxAge;
            PlanTime = planTime;
            ServiceTime = serviceTime;
            //TODO: validations
        }

        public Name Name{ get; private set; }
        public int MinAge { get; private set; }
        public int MaxAge { get; private set; }
        public int PlanTime { get; private set; }
        public int ServiceTime { get; private set; }

    }
}
