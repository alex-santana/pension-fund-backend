using Alex.Developer.Pension.Funds.Domain.Enums;
using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Entities;

namespace Alex.Developer.Pension.Funds.Domain.Entities
{
    public class Dependent : Entity
    {
        public Dependent(string employeeId, Name name, Document document, EDependentType depedentType, ERelationshipType relationshipType, decimal percent)
        {
            EmployeeId = employeeId;
            Name = name;
            Document = document;
            DepedentType = depedentType;
            RelationshipType = relationshipType;
            Percent = percent;

            AddNotifications(name, document);
        }

        public string EmployeeId { get; private set; }
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public EDependentType DepedentType { get; private set; }
        public ERelationshipType RelationshipType { get; private set; }
        public decimal Percent { get; private set; }
    }
}
