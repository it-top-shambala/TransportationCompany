using TransportationCompany.App;

Console.WriteLine("Выберите вариант перевозок");
Console.WriteLine("1. Пассажирские перевозки");
Console.WriteLine("2. Грузовые перевозки");
var transportationOption = Console.ReadLine();

Console.WriteLine("Выберите вид транспорта");
Console.WriteLine("1. Автомобильный транспорт");
Console.WriteLine("2. Воздушный транспорт");
var typeOfTransport = Console.ReadLine();

Transport transport = typeOfTransport switch
{
    "1" => // 1. Автомобильный транспорт
        transportationOption switch
        {
            "1" => new Bus(), // 1. Пассажирские перевозки
            "2" => new Truck() // 2. Грузовые перевозки
        },
    "2" => // 2. Воздушный транспорт
        transportationOption switch
        {
            "1" => new AirBus(), // 1. Пассажирские перевозки
            "2" => new CargoPlane() // 2. Грузовые перевозки
        }
};

switch (transport)
{
    case IPassengerTransportation passengerTransportation:
        passengerTransportation.BoardingOfPassengers();
        break;
    case ICargoTransportation cargoTransportation:
        cargoTransportation.LoadingOfCargo();
        break;
}

transport.Move();

switch (transport)
{
    case IPassengerTransportation passengerTransportation:
        passengerTransportation.DisembarkationOfPassengers();
        break;
    case ICargoTransportation cargoTransportation:
        cargoTransportation.UnloadingOfCargo();
        break;
}