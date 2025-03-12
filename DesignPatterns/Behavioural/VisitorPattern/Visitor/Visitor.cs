namespace DesignPatterns.Behavioural.VisitorPattern;

public interface Visitor
{
    public void VisitRetail(Client client);
    public void VisitRestaurant(Client client);
    public void VisitLaw(Client client);

}
