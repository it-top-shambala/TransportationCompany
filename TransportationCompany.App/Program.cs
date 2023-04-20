using TransportationCompany.App;

Console.WriteLine("Выберите вариант перевозок");
Console.WriteLine("1. Пассажирские перевозки");
Console.WriteLine("2. Грузовые перевозки");
var transportationOption = Console.ReadLine();

Console.WriteLine("Выберите вид транспорта");
Console.WriteLine("1. Автомобильный транспорт");
Console.WriteLine("2. Воздушный транспорт");
var typeOfTransport = Console.ReadLine();

Transport transport = null;
switch (typeOfTransport)
{
    case "1": // 1. Автомобильный транспорт
        switch (transportationOption)
        {
            case "1": // 1. Пассажирские перевозки
                transport = new Bus();
                break;
            case "2": // 2. Грузовые перевозки
                transport = new Truck();
                break;
        }
        break;
    case "2": // 2. Воздушный транспорт
        switch (transportationOption)
        {
            case "1": // 1. Пассажирские перевозки
                transport = new AirBus();
                break;
            case "2": // 2. Грузовые перевозки
                transport = new CargoPlane();
                break;
        }
        break;
}

if (transport is IPassengerTransportation)
{
    ((IPassengerTransportation)transport).BoardingOfPassengers();
} else if (transport is ICargoTransportation)
{
    ((ICargoTransportation)transport).LoadingOfCargo();
}
transport.Move();
if (transport is IPassengerTransportation)
{
    ((IPassengerTransportation)transport).DisembarkationOfPassengers();
} else if (transport is ICargoTransportation)
{
    ((ICargoTransportation)transport).UnloadingOfCargo();
}