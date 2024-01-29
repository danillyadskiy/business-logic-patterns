namespace BusinessLogicPatterns._4.EventSourcedDomainModel.Domain;

public interface IRepository
{
    IEnumerable<DomainEvent> LoadEvents(int id);
    
    IEnumerable<DomainEvent> LoadEvents(int id, int eventId);

    void CommitChanges(Ticket ticket);
}