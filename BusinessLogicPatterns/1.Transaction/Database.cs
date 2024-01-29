namespace BusinessLogicPatterns._1.Transaction;

public class Database
{
    public void StartTransaction() { }

    public string Load()
    {
        return "Ticket";
    }

    public void Close(string ticket) { }

    public void Commit() { }
}