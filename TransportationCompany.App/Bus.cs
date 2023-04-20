namespace TransportationCompany.App;

public class Bus : MotorTransport, IPassengerTransportation
{
    public void BoardingOfPassengers()
    {
        Console.WriteLine("Посадка пассажиров в автобус");
    }

    public void DisembarkationOfPassengers()
    {
        Console.WriteLine("Высадка пассажиров из автобуса");
    }
}