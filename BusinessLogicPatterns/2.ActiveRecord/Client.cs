namespace BusinessLogicPatterns._2.ActiveRecord;

public class Client
{
    private readonly Database _database;

    public Client()
    {
        _database = new Database();
    }
    
    public void Execute()
    {
        var ticketDetails = new
        {
            Id = 1, 
            Version = 0, 
            IsOpen = false
        };
        
        // Begin transaction 
        _database.StartTransaction();

        // Do some logic with ticket
        Ticket ticket = new Ticket();
        ticket.Id = ticketDetails.Id;
        ticket.Version = ticketDetails.Version;
        ticket.IsOpen = ticketDetails.IsOpen;
        ticket.Save();
        // Do some logic with ticket
        
        _database.Commit();
        // Finish transaction
        
        ShowState(ticket);
    }
    
    private void ShowState(Ticket ticket)
    {
        Console.WriteLine($"ticket-id: {ticket.Id}");
        Console.WriteLine($"ticket-version: {ticket.Version}");
        Console.WriteLine($"ticket-is-open: {ticket.IsOpen}");
    }
}