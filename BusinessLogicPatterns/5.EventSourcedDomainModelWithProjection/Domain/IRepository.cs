namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain;

public interface IRepository
{
    IEnumerable<DomainEvent> LoadEvents(int id);
    
    IEnumerable<DomainEvent> LoadEvents(int id, int eventId);

    void CommitChanges(Ticket ticket);
}