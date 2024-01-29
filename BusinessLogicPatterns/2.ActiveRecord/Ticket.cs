namespace BusinessLogicPatterns._2.ActiveRecord;

public class Ticket
{
    public int Id { get; set; }
    public int Version { get; set; }
    public bool IsOpen { get; set; }

    public void Save()
    {
        // Connection to DB and persisting User into DB
    }
}