namespace BusinessLogicPatterns._4.EventSourcedDomainModel.Domain;

public abstract class DomainEvent
{
    public DomainEvent(int id)
    {
        Id = id;
    }
    
    public int Id { get; private set; }
}