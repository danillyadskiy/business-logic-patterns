using BusinessLogicPatterns._3.DomainModel.Domain;

namespace BusinessLogicPatterns._3.DomainModel.Repositories;

public class Repository : IRepository
{
    private readonly List<Ticket> _tickets;

    public Repository()
    {
        _tickets = new List<Ticket>();
    }
    
    public Ticket Load(int id)
    {
        return _tickets.First(ticket => ticket.Id == id);
    }

    public void Save(Ticket ticket)
    {
        _tickets.Add(ticket);
    }
}