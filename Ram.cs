namespace Garage;

public class Ram : Vehicle
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives past. Bbbrrrrrrrrr!");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Ram turns left onto the gravel road.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram brakes into a hard stop to avoid the deer in the road.");
    }
}