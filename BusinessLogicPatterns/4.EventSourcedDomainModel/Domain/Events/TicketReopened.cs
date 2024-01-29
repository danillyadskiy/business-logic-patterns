namespace BusinessLogicPatterns._4.EventSourcedDomainModel.Domain.Events;

public class TicketReopened : DomainEvent
{
    public TicketReopened(int id) : base(id) { }
}