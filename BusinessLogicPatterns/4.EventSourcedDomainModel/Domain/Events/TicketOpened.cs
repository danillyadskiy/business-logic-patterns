namespace BusinessLogicPatterns._4.EventSourcedDomainModel.Domain.Events;

public class TicketOpened : DomainEvent
{
    public TicketOpened(int id) : base(id) { }
}