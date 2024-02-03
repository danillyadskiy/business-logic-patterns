using BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain;

namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Repositories;

public class Repository : IRepository
{
    private List<DomainEvent> _events;

    public Repository()
    {
        _events = new List<DomainEvent>();
    }
    
    public IEnumerable<DomainEvent> LoadEvents(int id)
    {
        return _events.Where(@event => @event.Id == id);
    }
    
    public IEnumerable<DomainEvent> LoadEvents(int id, int eventId)
    {
        return _events.Where(@event => @event.Id == id).Take(eventId + 1);
    }

    public void CommitChanges(Ticket ticket)
    {
        _events = ticket.DomainEvents;
    }
}