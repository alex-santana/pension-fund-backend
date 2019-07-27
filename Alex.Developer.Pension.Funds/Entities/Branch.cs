using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Branch :Entity
    {
        public Branch(Name name)
        {
            Name = name;
            _employees = new List<Employee>();
        }
        public Name Name { get; private set; }
        private IList<Employee> _employees;
        public IReadOnlyCollection<Employee> Employees { get { return _employees.ToArray(); } }


    }
}
