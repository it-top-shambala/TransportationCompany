namespace TransportationCompany.App;

public class AirBus : AirTransport, IPassengerTransportation
{
    public void BoardingOfPassengers()
    {
        Console.WriteLine("Посадка пассажиров в самолёт");
    }

    public void DisembarkationOfPassengers()
    {
        Console.WriteLine("Высадка пассажиров из самолёта");
    }
}