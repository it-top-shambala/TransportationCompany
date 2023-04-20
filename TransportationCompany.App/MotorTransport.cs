namespace TransportationCompany.App;

public abstract class MotorTransport : Transport
{
    public override void Move()
    {
        Console.WriteLine("Движемся по автомобильным дорогам");
    }
}