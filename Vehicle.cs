namespace Garage;

public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }

    public virtual void Turn()
    {
        Console.WriteLine("Turning left!");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Coming to a smooth stop.");
    }
}