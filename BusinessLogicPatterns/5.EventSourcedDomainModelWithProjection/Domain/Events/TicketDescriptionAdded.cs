namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain.Events;

public class TicketDescriptionAdded : DomainEvent
{
    public TicketDescriptionAdded(int id, string description) : base(id)
    {
        Description = description;
    }
    
    public string Description { get; private set; }
}