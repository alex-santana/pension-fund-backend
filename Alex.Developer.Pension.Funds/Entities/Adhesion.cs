using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Adhesion :Entity
    {
        public DateTime Initial { get; private set; }
        public DateTime Admission { get; private set; }
        public DateTime Suspension { get; private set; }
        public DateTime Dismissal { get; private set; }
        public Date Date { get; private set; }
        private IList<Movement> _movements;
        public IReadOnlyCollection<Movement> Movements { get { return _movements.ToArray(); } }

        public Plan Plan { get; private set; }






    }
}
