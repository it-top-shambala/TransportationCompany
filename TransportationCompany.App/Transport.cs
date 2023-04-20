namespace TransportationCompany.App;

public abstract class Transport
{
    public int passengerCapacity;
    public double carryingCapacity;

    public abstract void Move();
}