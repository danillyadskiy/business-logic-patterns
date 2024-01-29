namespace BusinessLogicPatterns._4.EventSourcedDomainModel.Domain.Events;

public class TicketInitialized : DomainEvent
{
    public TicketInitialized(int id) : base(id) { }
}