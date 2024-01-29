using BusinessLogicPatterns._3.DomainModel.Domain;
using BusinessLogicPatterns._3.DomainModel.Repositories;

namespace BusinessLogicPatterns._3.DomainModel;

public class Client
{
    private IRepository _repository;

    public Client()
    {
        _repository = new Repository();
    }
    
    public void Execute()
    {
        int ticketId = 1;
        
        // Begin transaction 
        
        // Do some logic with ticket
        Ticket ticket = new Ticket();
        ticket.Initialize(ticketId);
        ticket.Open();
        ticket.Close();
        // Do some logic with ticket
        
        _repository.Save(ticket);
        // Finish transaction

        Ticket repositoryTicket = _repository.Load(ticketId);
        ShowState(repositoryTicket);
        
    }

    private void ShowState(Ticket ticket)
    {
        Console.WriteLine($"ticket-id: {ticket.Id}");
        Console.WriteLine($"ticket-version: {ticket.Version}");
        Console.WriteLine($"ticket-is-open: {ticket.IsOpen}");
    }
}