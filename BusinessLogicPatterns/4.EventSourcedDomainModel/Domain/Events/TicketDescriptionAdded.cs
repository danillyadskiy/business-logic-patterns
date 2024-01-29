namespace BusinessLogicPatterns._4.EventSourcedDomainModel.Domain.Events;

public class TicketDescriptionAdded : DomainEvent
{
    public TicketDescriptionAdded(int id, string description) : base(id)
    {
        Description = description;
    }
    
    public string Description { get; private set; }
}