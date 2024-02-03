namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain.Events;

public class TicketInitialized : DomainEvent
{
    public TicketInitialized(int id) : base(id) { }
}