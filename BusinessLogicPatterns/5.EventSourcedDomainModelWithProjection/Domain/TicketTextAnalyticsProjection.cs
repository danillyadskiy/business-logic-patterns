using BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain.Events;

namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain;

public class TicketTextAnalyticsProjection
{
    public TicketTextAnalyticsProjection(IEnumerable<DomainEvent> events)
    {
        Texts = new List<string>();
        
        foreach (var @event in events)
            Apply((dynamic)@event); 
    }
    
    public int Id { get; private set; }
    public int Version { get; private set; }
    public List<string> Texts { get; private set; }

    private void Apply(TicketInitialized @event)
    {
        Id = @event.Id;
        Version = 0;
    }
    
    private void Apply(TicketOpened @event)
    {
        Version++;
    }

    private void Apply(TicketDescriptionAdded @event)
    {
        Texts.Add(@event.Description);
        Version++;
    }
    
    private void Apply(TicketClosed @event)
    {
        Version++;
    }
    
    private void Apply(TicketReopened @event)
    {
        Version++;
    }
}