namespace BusinessLogicPatterns._3.DomainModel.Domain;

public class Ticket
{
    public int Id { get; private set; }
    public int Version { get; private set; }
    public bool IsOpen { get; private set; }

    public void Initialize(int id)
    {
        Id = id;
        Version = 0;
    }
    
    public void Open()
    {
        IsOpen = true;
        Version++;
    }

    public void Close()
    {
        IsOpen = false;
        Version++;
    }
}