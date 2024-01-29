using Client1 = BusinessLogicPatterns._1.Transaction.Client;
using Client2 = BusinessLogicPatterns._2.ActiveRecord.Client;
using Client3 = BusinessLogicPatterns._3.DomainModel.Client;
using Client4 = BusinessLogicPatterns._4.EventSourcedDomainModel.Client;

namespace BusinessLogicPatterns;

public class Program
{
    public static void Main(string[] args)
    {
        // ExecuteClient1();
        // ExecuteClient2();
        // ExecuteClient3();
        // ExecuteClient4();
    }
    
    private static void ExecuteClient1()
    {
        Client1 client = new Client1();
        client.Execute();
    }
    
    private static void ExecuteClient2()
    {
        Client2 client = new Client2();
        client.Execute();
    }
    
    private static void ExecuteClient3()
    {
        Client3 client = new Client3();
        client.Execute();
    }

    private static void ExecuteClient4()
    {
        Client4 client = new Client4();
        client.Execute();
    }
}