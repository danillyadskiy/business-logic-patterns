namespace BusinessLogicPatterns._1.Transaction;

public class Client
{
    private readonly Database _database;
    private readonly File _file;
    
    public Client()
    {
        _database = new Database();
        _file = new File();
    }
    
    public void Execute()
    {
        // Begin transaction 
        _database.StartTransaction();
        
        // Do some logic with ticket
        string ticket = _database.Load();
        string ticketInfo = _file.Load();
        
        _file.Write(ticketInfo);
        _database.Close(ticket);
        // Do some logic with ticket
        
        _database.Commit();
        // Finish transaction
        
        Console.WriteLine(ticket);
        Console.WriteLine(ticketInfo);
    }
}