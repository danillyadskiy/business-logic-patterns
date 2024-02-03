using BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain.Events;

namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain;

public class Ticket
{
    public Ticket(IEnumerable<DomainEvent> events)
    {
        State = new TicketState();
        DomainEvents = new List<DomainEvent>();
        
        AddEvents(events);
    }
    
    public TicketState State { get; private set; }
    public List<DomainEvent> DomainEvents { get; private set; }
    
    public void Initialize(int id)
    {
        DomainEvent @event = new TicketInitialized(id);
        AddEvent(@event);
    }
    
    public void Open()
    {
        DomainEvent @event = new TicketOpened(State.Id);
        AddEvent(@event);
    }

    public void AddDescription(string description)
    {
        DomainEvent @event = new TicketDescriptionAdded(State.Id, description);
        AddEvent(@event);
    } 
    
    public void Close()
    {
        DomainEvent @event = new TicketClosed(State.Id);
        AddEvent(@event);
    }
    
    public void Reopen()
    {
        DomainEvent @event = new TicketReopened(State.Id);
        AddEvent(@event);
    }
    
    private void AddEvents(IEnumerable<DomainEvent> events)
    {
        foreach (var @event in events)
            AddEvent(@event);
    }

    private void AddEvent(DomainEvent @event)
    {
        DomainEvents.Add(@event);
        ((dynamic)State).Apply((dynamic)@event);
    }
}