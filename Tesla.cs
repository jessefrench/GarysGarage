namespace Garage;

public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla drives past. Whhhhhiirrrr!");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Tesla turns into the charging station.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla rolls to a stop for a software update.");
    }
}