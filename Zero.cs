namespace Garage;

public class Zero : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero drives past. Whhiimmmmmm!");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Zero turns right onto the highway.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero slides to a stop anime style.");
    }
}