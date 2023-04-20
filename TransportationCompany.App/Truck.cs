namespace TransportationCompany.App;

public class Truck : MotorTransport, ICargoTransportation
{
    public void LoadingOfCargo()
    {
        Console.WriteLine("Погрузка груза в грузовик");
    }

    public void UnloadingOfCargo()
    {
        Console.WriteLine("Разгрузка груза из грузовика");
    }
}