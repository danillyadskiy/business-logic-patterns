namespace BusinessLogicPatterns._4.EventSourcedDomainModel.Domain.Events;

public class TicketClosed : DomainEvent
{
    public TicketClosed(int id) : base(id) { }
}