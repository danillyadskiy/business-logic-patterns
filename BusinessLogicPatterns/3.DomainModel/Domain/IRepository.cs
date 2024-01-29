namespace BusinessLogicPatterns._3.DomainModel.Domain;

public interface IRepository
{
    Ticket Load(int id);

    void Save(Ticket ticket);
}