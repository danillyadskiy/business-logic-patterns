using BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain;
using BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Domain.Events;
using BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection.Repositories;

namespace BusinessLogicPatterns._5.EventSourcedDomainModelWithProjection;

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
        TicketTextAnalyticsProjection projection = new TicketTextAnalyticsProjection(events);
        
        Console.WriteLine($"ticket-id: {projection.Id}");
        Console.WriteLine($"version: {projection.Version}");

        for (int i = 0; i < projection.Texts.Count; i++)
            Console.WriteLine($"text {i + 1}: {projection.Texts[i]}");
    }
}