using BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain.Events;

namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain;

public class TicketState
{
    public int Id { get; private set; }
    public int Version { get; private set; }
    public bool IsOpened { get; private set; }
    public string Description { get; private set; }
    
    public void Apply(TicketInitialized @event)
    {
        Id = @event.Id;
        Version = 0;
        IsOpened = false;
    }
    
    public void Apply(TicketOpened @event)
    {
        Version++;
        IsOpened = true;
    }

    public void Apply(TicketDescriptionAdded @event)
    {
        Version++;
        Description = @event.Description;
        
    }
    
    public void Apply(TicketClosed @event)
    {
        Version++;
        IsOpened = false;
    }
    
    public void Apply(TicketReopened @event)
    {
        Version++;
        IsOpened = true;
    }
}