using BusinessLogicPatterns._4.EventSourcedDomainModel.Domain;
using BusinessLogicPatterns._4.EventSourcedDomainModel.Domain.Events;
using BusinessLogicPatterns._4.EventSourcedDomainModel.Repositories;

namespace BusinessLogicPatterns._4.EventSourcedDomainModel;

public class Client
{
    private readonly IRepository _repository;

    public Client()
    {
        _repository = new Repository();
    }
    
    public void Execute()
    {
        int ticketId = 1;
        int eventId = 6;
        
        // Begin transaction 
        IEnumerable<DomainEvent> events = _repository.LoadEvents(ticketId);
        Ticket ticket = new Ticket(events);
        
        // Do some logic with ticket
        ticket.Initialize(ticketId);
        ticket.Open();
        ticket.AddDescription("Some description 1");
        ticket.Close();
        ticket.Reopen();
        ticket.AddDescription("Some description 2");
        ticket.Close();
        // Do some logic with ticket

        _repository.CommitChanges(ticket);
        // Finish transaction

        events = _repository.LoadEvents(ticketId, eventId);
        ShowEvents(events);

    }
    
    private void ShowEvents(IEnumerable<DomainEvent> events)
    {
        List<DomainEvent> domainEvents = events.ToList();
        
        for (int i = 0; i < domainEvents.Count; i++)
        {
            switch (domainEvents[i])
            {
                case TicketInitialized @event: 
                    Console.WriteLine($"ticket-id: {@event.Id}");
                    Console.WriteLine($"event-id: {i}");
                    Console.WriteLine($"event-type: {@event.GetType().Name}");
                    Console.WriteLine($"timestamp: {DateTime.Now}");
                    break;
                    
                case TicketOpened @event: 
                    Console.WriteLine($"ticket-id: {@event.Id}");
                    Console.WriteLine($"event-id: {i}");
                    Console.WriteLine($"event-type: {@event.GetType().Name}");
                    Console.WriteLine($"timestamp: {DateTime.Now}");
                    break;
                    
                case TicketDescriptionAdded @event: 
                    Console.WriteLine($"ticket-id: {@event.Id}");
                    Console.WriteLine($"event-id: {i}");
                    Console.WriteLine($"event-type: {@event.GetType().Name}");
                    Console.WriteLine($"description: {@event.Description}");
                    Console.WriteLine($"timestamp: {DateTime.Now}");
                    break;
                    
                case TicketClosed @event: 
                    Console.WriteLine($"ticket-id: {@event.Id}");
                    Console.WriteLine($"event-id: {i}");
                    Console.WriteLine($"event-type: {@event.GetType().Name}");
                    Console.WriteLine($"timestamp: {DateTime.Now}");
                    break;
                
                case TicketReopened @event: 
                    Console.WriteLine($"ticket-id: {@event.Id}");
                    Console.WriteLine($"event-id: {i}");
                    Console.WriteLine($"event-type: {@event.GetType().Name}");
                    Console.WriteLine($"timestamp: {DateTime.Now}");
                    break;
            }
                
            Console.WriteLine();
        }
    }
}