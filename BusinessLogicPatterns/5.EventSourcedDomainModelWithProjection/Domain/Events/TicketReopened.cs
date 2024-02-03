namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain.Events;

public class TicketReopened : DomainEvent
{
    public TicketReopened(int id) : base(id) { }
}