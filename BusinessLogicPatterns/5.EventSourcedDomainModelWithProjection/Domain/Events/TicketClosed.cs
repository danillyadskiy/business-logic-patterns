namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain.Events;

public class TicketClosed : DomainEvent
{
    public TicketClosed(int id) : base(id) { }
}