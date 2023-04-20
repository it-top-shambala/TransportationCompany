namespace TransportationCompany.App;

public class CargoPlane : AirTransport, ICargoTransportation
{
    public void LoadingOfCargo()
    {
        Console.WriteLine("Погрузка груза в самолёт");
    }

    public void UnloadingOfCargo()
    {
        Console.WriteLine("Разгрузка груза из самолёта");
    }
}