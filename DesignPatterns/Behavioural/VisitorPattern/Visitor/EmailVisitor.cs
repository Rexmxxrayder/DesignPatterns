namespace DesignPatterns.Behavioural.VisitorPattern;

public class EmailVisitor : Visitor
{
    public void VisitRetail(Client client)
    {
        Console.WriteLine("email retail");
    }
    public void VisitRestaurant(Client client)
    {
        Console.WriteLine("email restaurant");
    }
    public void VisitLaw(Client client)
    {
        Console.WriteLine("email law");
    }

}
