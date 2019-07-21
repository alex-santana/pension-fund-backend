using Flunt.Notifications;
using System;

namespace Alex.Developer.Pension.Funds.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        
}
