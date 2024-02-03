namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain.Events;

public class TicketOpened : DomainEvent
{
    public TicketOpened(int id) : base(id) { }
}