namespace TransportationCompany.App;

public abstract class AirTransport : Transport
{
    public override void Move()
    {
        Console.WriteLine("Летим");
    }
}