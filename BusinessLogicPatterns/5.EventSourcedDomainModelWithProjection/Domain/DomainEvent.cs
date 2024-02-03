namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain;

public abstract class DomainEvent
{
    public DomainEvent(int id)
    {
        Id = id;
    }
    
    public int Id { get; private set; }
}